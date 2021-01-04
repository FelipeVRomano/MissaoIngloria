using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    //raioParaObjetos
    [SerializeField]
    private float raio;

    //valorShade Objetos
    [SerializeField]
    private float valorShader;
    [SerializeField]
    private Outline meshActual;


    [SerializeField]
    Action objAcao;
    public bool controle;


    //carregandoInimigoMorto
    [SerializeField]
    private Transform posParaInimigo;
    [HideInInspector]
    public bool carregando;
    Movimento moviment;
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    Transform Player;
    Rigidbody enemyBody;
    bool controleUp;
    [SerializeField]
    Interpolacao interP;
    [SerializeField]
    Interpolacao interP2;
    [SerializeField]
    LayerMask mask;

    Arma armaPlayer;
    Moeda moedaPlayer;
    Esconder hide;
    public ControleInput inputCamera;
    private LocalizaPlayer playerMap;
    [SerializeField]
    TextUI playerTextUI;
    public GameObject backImageText;

    public static bool podeSeEsconder;
    [SerializeField]
    DropaEnemy dropControl;


    public GameObject tutMap;
    public GameObject tutMapBack;

    public GameObject carregandoCorpo;

    private bool primerCarregandoCorpo;

    private void Start()
    {
        moviment = GameObject.Find("Player").GetComponent<Movimento>();
        Player = transform.parent;
        playerMap = GameObject.Find("Player").GetComponent<LocalizaPlayer>();
        armaPlayer = GameObject.Find("Arma").GetComponent<Arma>();
        moedaPlayer = GameObject.Find("Camera").GetComponent<Moeda>();
        podeSeEsconder = true;
    }
    void Update()
    {
     
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 20, mask))
        {

            if (hit.collider.gameObject.GetComponent<Outline>() != null)
            {
               
                //if(hit.collider.gameObject.CompareTag("item"))
                if(hit.collider.CompareTag("Ammo") && hit.distance < raio)
                {
                    if (meshActual == null)
                    meshActual = hit.collider.gameObject.GetComponent<Outline>();
                    ShowOutLine();
                    backImageText.SetActive(true);
                    playerTextUI.atualizaTextUI("Aperte Y para pegar munição", "Aperte E para pegar munição");
                    //if(Input.GetButtonDown("Interacao"))
                    if (inputCamera.inputController.Player.Interacao.triggered)
                    {
                        backImageText.SetActive(false);
                        playerTextUI.desativaTxt();
                        armaPlayer.addMunicao();

                        meshActual = null;
                        hit.collider.gameObject.SetActive(false);
                    }
                }
                else if(hit.collider.CompareTag("Mapa") && hit.distance < raio)
                {
                    if (meshActual == null)
                        meshActual = hit.collider.gameObject.GetComponent<Outline>();
                    ShowOutLine();
                    backImageText.SetActive(true);
                    playerTextUI.atualizaTextUI("Aperte Y para pegar o Mapa", "Aperte E para pegar o Mapa");
                    if (inputCamera.inputController.Player.Interacao.triggered)
                    {
                        backImageText.SetActive(false);
                        playerTextUI.desativaTxt();
                        playerMap.liberouMapa = true;

                        HUDPlayer.ativaMapa = true;

                        hit.collider.gameObject.SetActive(false);
                        tutMapBack.SetActive(true);
                        tutMap.SetActive(true);
                    }
                }
                else if (hit.collider.CompareTag("Moeda") && hit.distance < raio)
                {
                    if (meshActual == null)
                        meshActual = hit.collider.gameObject.GetComponent<Outline>();
                    ShowOutLine();
                    backImageText.SetActive(true);
                    playerTextUI.atualizaTextUI("", "Aperte E para pegar a Moeda");
                    // if (Input.GetButtonDown("Interacao"))
                    if (inputCamera.inputController.Player.Interacao.triggered)
                    {
                        backImageText.SetActive(false);
                        playerTextUI.desativaTxt();
                        moedaPlayer.addMoeda();
                        meshActual = null;
                        hit.collider.gameObject.SetActive(false);
                    }
                }
                else if(hit.collider.CompareTag("Esconder") && hit.distance < raio)
                {
                    if (meshActual == null)
                        meshActual = hit.collider.gameObject.GetComponent<Outline>();
                    if (hide == null)
                        hide = hit.collider.gameObject.GetComponent<Esconder>();
                    if (carregando)
                    {
                        ShowOutLine();
                        backImageText.SetActive(true);
                        playerTextUI.atualizaTextUI("", "Aperte E para esconder o Inimigo");
                        //  if(Input.GetButtonDown("Interacao"))
                        if (inputCamera.inputController.Player.Interacao.triggered)
                        {
                            backImageText.SetActive(false);
                            playerTextUI.desativaTxt();
                            hide.EscondePlayer();
                            enemy.transform.parent = null;
                            enemy = null;
                            enemyBody = null;
                            interP2 = null;
                            carregando = false;
                            controleUp = false;
                            meshActual.gameObject.tag = "Untagged";
                            HideOutLine();
                        }
                    }
                    if(hide != null)
                    {
                        ShowOutLine();
                        backImageText.SetActive(true);
                        playerTextUI.atualizaTextUI("", "Aperte E para se esconder");
                        //  if(Input.GetButtonDown("Interacao") && !hide.Escondido)
                        if (podeSeEsconder)
                        {
                            if (inputCamera.inputController.Player.Interacao.triggered && !hide.Escondido && !hide.controle2 && !EnemyIA.procurado)
                            {
                                backImageText.SetActive(false);
                                playerTextUI.desativaTxt();
                                hide.somePlayer();
                                HideOutLine();
                                
                            }

                            if (EnemyIA.procurado)
                            {
                                backImageText.SetActive(true);
                                playerTextUI.atualizaTextUI("", "Não pode se esconder sendo visto");
                            }
                        }
                    }

                }
                else
                {
                    HideOutLine();
                }
            }
            else if(hit.collider.gameObject.GetComponent<Interpolacao>() != null)
            {
                if (hit.collider.CompareTag("Inimigo"))
                {
                    if (interP == null)
                        interP = hit.collider.gameObject.GetComponent<Interpolacao>();
                    
                    if (meshActual == null)
                        meshActual = interP.pai;
                    if (objAcao == null)
                        objAcao = interP.paiA;

                    if (objAcao.adcTimer == false)
                    {
                        showOutLineEnemy();
                        backImageText.SetActive(true);
                        playerTextUI.atualizaTextUI("", "Aperte F para marcar o Inimigo");
                        // if (Input.GetButtonDown("Marcar"))
                        if (inputCamera.inputController.Player.MarcarInimigos.triggered)
                        {
                            backImageText.SetActive(false);
                            playerTextUI.desativaTxt();
                            //meshEnemies.Add(hit.collider.gameObject.GetComponent<MeshRenderer>());
                            HideOutLine();
                            objAcao.highlightEnemy();
                            objAcao = null;
                            controle = true;
                            // showOutLineEnemy();
                        }
                    }
                    else
                    {
                        controle = true;
                    }
                }
                else if (hit.collider.CompareTag("InimigoMorto") && hit.distance < raio)
                {
                    if (interP2 == null)
                        interP2 = hit.collider.gameObject.GetComponent<Interpolacao>();

                    if (meshActual == null)
                    {
                        enemy = interP2.pai.gameObject;
                        enemyBody = interP2.rigidBody;
                        meshActual = interP2.pai;
                    }
                    ShowOutLine();
                    backImageText.SetActive(true);
                    playerTextUI.atualizaTextUI("", "Aperte E para carregar o Inimigo");
                    // if (Input.GetButtonDown("Interacao"))
                    if (inputCamera.inputController.Player.Interacao.triggered)
                    {
                        backImageText.SetActive(false);
                        playerTextUI.desativaTxt();
                        //Som de pegar corpo
                        SendMessage("Play");

                        //   controleUp = true;
                        enemyBody.isKinematic = true;
                        // enemy.transform.parent = Player;
                        enemy.transform.parent = posParaInimigo;
                        enemy.transform.localPosition = posParaInimigo.localPosition;
                        interP2.desativa();
                        carregando = true;
                        HideOutLine();

                        if (primerCarregandoCorpo == false)
                        {
                            backImageText.SetActive(true);
                            playerTextUI.atualizaTextUI("", "Aperte E para soltar o Inimigo, ou Esconda-o em um Armário/Caixa Aberta");
                            
                        }
                    }

                }
                
            }
            else
            {
                if(meshActual != null)
                {
                    HideOutLine();
                }
            }
               

        }   
        else
        {
            if(meshActual != null)
            {
                HideOutLine();
            }
        }
        Debug.DrawLine(transform.position, transform.forward, Color.red);
        // if(Input.GetButtonUp("Interacao") && carrying)
        if (!inputCamera.inputController.Player.Interacao.triggered && carregando)
        {
            controleUp = true;
        }
        // if(controleUp && Input.GetButtonDown("Interacao"))
        if (controleUp && inputCamera.inputController.Player.Interacao.triggered)
        {

            Vector3 posGuardada = posParaInimigo.localPosition;
            posParaInimigo.localPosition = dropControl.posReal.localPosition;
            enemy.transform.parent = null;
            enemy = null;
            enemyBody.isKinematic = false;
            enemyBody = null;
            posParaInimigo.localPosition = posGuardada;
            interP2.ativa();
            interP2 = null;
            carregando = false;

            if (primerCarregandoCorpo == false)
            {
                backImageText.SetActive(false);
                playerTextUI.desativaTxt();
                primerCarregandoCorpo = true;
            }

            controleUp = false;
        }

        if (carregando == true)
        {
            carregandoCorpo.SetActive(true);
        }

        if (carregando == false)
        {
            carregandoCorpo.SetActive(false);
        }
    }

    public void ShowOutLine()
    {

        meshActual.enabled = true;
    }

    public void showOutLineEnemy()
    {
        meshActual.enabled = true;
    }

    public void HideOutLine()
    {
        if (enemy != null && !carregando)
        {
            enemyBody.isKinematic = false;
            enemyBody = null;
            interP = null;
            enemy = null;
        }
        if (meshActual != null && !controle)
        {
            interP2 = null;
            meshActual.enabled = false;
            meshActual = null;
            
        }
        if(controle)
        {
            if (objAcao.adcTimer == false)
            {
                meshActual.enabled = false;
            }
            objAcao = null;       
            meshActual = null;
            interP = null;
            controle = false;
        }
        backImageText.SetActive(false);
        playerTextUI.desativaTxt();
        if (hide != null)
            hide = null;
    }
}
