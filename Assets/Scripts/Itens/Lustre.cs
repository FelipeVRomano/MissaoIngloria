using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lustre : MonoBehaviour
{
    [HideInInspector]
    public bool triggerAtivado;
    Rigidbody rigidLight;
    BoxCollider colliderLight;
    [SerializeField]
    BoxCollider triggerLight;
    //EnemyIA IAEnemy;
    EnemyTeste enemyTeste;
    Arma arma;
    Interpolacao interP;
    [SerializeField]
    GameManager gm;
    [SerializeField]
    private float timer;
    bool triggerTimer;
    private void Awake()
    {
        arma = GameObject.Find("Arma").GetComponent<Arma>();
    }
    void Start()
    {
        triggerLight = GetComponent<BoxCollider>();
        rigidLight = gameObject.GetComponentInParent<Rigidbody>();
        gm = GameObject.Find("GAME MANAGER").GetComponent<GameManager>();
    }
    private void Update()
    {
        if (triggerTimer)
            timer -= Time.deltaTime;

        if(timer <= 0)
        {
            triggerTimer = false;
            gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
    public void luzCaindo()
    {
        triggerAtivado = true;
        triggerTimer = true;
        rigidLight.isKinematic = false;
        triggerLight.enabled = true;
    }

    public void OnTriggerEnter(Collider collision)
    {
        print(collision.gameObject.tag + "  " + collision.gameObject.name + "AHHHHHHH");
      
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Vida>().Morreu();
        }
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            if (enemyTeste == null)
                enemyTeste = collision.gameObject.GetComponent<EnemyTeste>();
            if (enemyTeste == null)
            {
                if(interP == null)
                interP = collision.gameObject.GetComponent<Interpolacao>();                
            }     
            if(enemyTeste != null)
            {
                if(enemyTeste.boss)
                {
                    gm.qntBoss--;
                }
                arma.MorteInimigo(enemyTeste.gameObject);
                enemyTeste = null;
                interP = null;
            }
            else if(interP != null)
            {
                if(interP.paiEnemy.boss)
                {
                    gm.qntBoss--;
                }
                arma.MorteInimigo(interP.obj);
                enemyTeste = null;
                interP = null;
            }
        }
    }
}
