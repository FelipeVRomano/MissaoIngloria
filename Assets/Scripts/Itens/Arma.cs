using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    [SerializeField]
    float range;
    [SerializeField]
    float municaoMaxima;
    float ammo;
    public float ammoGuardada;
    [SerializeField]
    private float adicionaAmmoColetavel;
    [SerializeField]
    GameObject marca;
    [SerializeField]
    GameObject marca2;
    [SerializeField]
    private float tempoReload;
    bool canShot;
    [HideInInspector]
    public bool carregando;
    [SerializeField]
    //EnemyTeste enemy;
    EnemyIA enemy;
    [SerializeField]
    LayerMask mask;
    [SerializeField]
    Interpolacao interP;
    public Animator animator;
    [SerializeField]
    private Text ammoTxt;
    Lustre luz;

    public static bool fazBarulhoTiro;
    public static Vector3 posBarulhoTiro;
    public GameObject vilaoMortoPrefab;
    public GameManager gm;
    Outline Lustre;
    Lustre triggerAtv;
    public ControleInput inputGun;
    public GameObject sangueParticle;
    public ParticleSystem[] particulaTiro;
    private void Start()
    {
        animator = GetComponent<Animator>();
        canShot = true;
        ammo = municaoMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputGun.inputController.Player.Atirar.triggered && canShot)
        {
            Atirar();
            ammo--;
            posBarulhoTiro = transform.position;
            fazBarulhoTiro = true;
        }

        if (ammo <= 0 && !carregando && ammoGuardada > 0)
            StartCoroutine(reload());

        if (ammo <= 0)
            canShot = false;

        if (ammoTxt.enabled)
            ammoTxt.text = ammo.ToString() + " / " + ammoGuardada.ToString();

        Vector2 cordernada = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray raio = Camera.main.ScreenPointToRay(cordernada);
        RaycastHit hit;

        if (Physics.Raycast(raio, out hit, range, mask))
        {
            if (hit.collider.gameObject.CompareTag("Lustre"))
            {
                if (triggerAtv == null)
                    triggerAtv = hit.collider.transform.GetChild(0).GetComponent<Lustre>();
                if (Lustre == null)
                    Lustre = hit.collider.gameObject.GetComponent<Outline>();
                if (!triggerAtv.triggerAtivado)
                    Lustre.enabled = true;
                else
                {
                    Lustre.enabled = false;
                }
            }
            else
            {
                if (Lustre != null)
                {
                    triggerAtv = null;
                    Lustre.enabled = false;
                    Lustre = null;
                }
            }
        }
    }
    public void LuzDesativa()
    {
        if (Lustre != null)
        {
            triggerAtv = null;
            Lustre.enabled = false;
            Lustre = null;
        }
    }
    void Atirar()
    {
        Vector2 cordernada = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray raio = Camera.main.ScreenPointToRay(cordernada);
        RaycastHit hit;
        particulaTiro[0].Play();
        particulaTiro[1].Play();
        particulaTiro[2].Play();
        if (Physics.Raycast(raio, out hit, range, mask))
        {
            Vector3 posicao = hit.point + hit.normal / 100;
            Quaternion rotacao = Quaternion.LookRotation(-hit.normal);
            if (hit.collider.CompareTag("Inimigo") || hit.collider.CompareTag("InimigoMorto"))
            {
                GameObject copia = Instantiate(sangueParticle, posicao, rotacao);
                copia.transform.parent = hit.collider.gameObject.transform;
                Destroy(copia, 3);
            }
            else
            {
                //Som de atingir objeto
                hit.collider.gameObject.AddComponent<FMODUnity.StudioEventEmitter>();
                hit.collider.gameObject.GetComponent<FMODUnity.StudioEventEmitter>().Event = "event:/Bullet_object";
                hit.collider.SendMessage("Play");

              //  GameObject copia2 = Instantiate(marca2, posicao, rotacao);
                //print(hit.collider.name);
               // copia2.transform.parent = hit.collider.gameObject.transform;
               // Destroy(copia2, 3);
            }
            if (hit.collider.CompareTag("Inimigo"))
            {
                if (interP == null)
                    interP = hit.collider.gameObject.GetComponent<Interpolacao>();
                
                if (enemy == null)
                {
                    enemy = interP.paiEnemy;

                }

                if (!enemy.tomouTiro)
                    enemy.tomouTiro = true;
                else
                {
                    if (enemy.boss && !enemy.mataBoss)
                    {
                        gm.qntBoss--;
                        enemy.mataBoss = true;
                    }
                    MorteInimigo(interP.obj);
                }

            }
            
            if (hit.collider.name == "cabeca" && !hit.collider.GetComponent<Interpolacao>().paiEnemy.capacete)
            {
                if (enemy.boss && !enemy.mataBoss)
                {
                    gm.qntBoss--;
                    enemy.mataBoss = true;
                }
                MorteInimigo(interP.obj);

                if(!gm.capacete)
                gm.qntTiroCabeça++;
                
                
            }
            if (hit.collider.name == "capacete")
            {

                if (interP == null)
                    interP = hit.collider.gameObject.GetComponent<Interpolacao>();
                if (enemy == null)
                {
                    enemy = interP.paiEnemy;

                }

                hit.collider.name = "cabeca";
                gm.capacete = true;

            }
            enemy = null;
            interP = null;
        }
    }

    IEnumerator reload()
    {
        RayCastCamera.podeSeEsconder = false;
        carregando = true;
        canShot = false;
        animator.SetBool("recarregando", true);
        yield return new WaitForSeconds(tempoReload);
        ammo+= 2;
        canShot = true;
        carregando = false;
        animator.SetBool("recarregando", false);
        if(ammoGuardada > 1)
        ammoGuardada -=2;
        else if(ammoGuardada == 1)
        {
            ammoGuardada -= 1;
        }
        RayCastCamera.podeSeEsconder = true;

    }
    public void addMunicao()
    {
        ammoGuardada += adicionaAmmoColetavel;
    }
    public static bool inimigoRespawnable;
    public void MorteInimigo(GameObject inimigoMorto)
    {
        if (!inimigoMorto.GetComponent<EnemyIA>().morto)
        {
            inimigoMorto.GetComponent<EnemyIA>().morto = true;

            if (gm.bossAtuais.Contains(inimigoMorto))
                gm.bossAtuais.Remove(inimigoMorto);

            Instantiate(vilaoMortoPrefab, inimigoMorto.transform.position, inimigoMorto.transform.rotation); 
            inimigoMorto.SetActive(false);
        }
            Destroy(inimigoMorto.transform.gameObject,0.1f);

        }
     }

  




   
    
