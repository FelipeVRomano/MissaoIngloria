using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacaDano : MonoBehaviour
{
    
    [SerializeField]
    //EnemyTeste enemy;
    EnemyIA enemy;
    [SerializeField]
    Interpolacao interP;
    [SerializeField]
    Faca facada;
    [SerializeField]
    Arma arma;
    BoxCollider boxcol;
    [SerializeField]
    GameManager gm;
    [HideInInspector]
    public int valor;
    // Start is called before the first frame update
    void Start()
    {
        boxcol = GetComponent<BoxCollider>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Inimigo"))
        {

            interP = collision.gameObject.GetComponent<Interpolacao>();
            enemy = interP.paiEnemy;
            boxcol.isTrigger = true;
            if (!enemy.colete && facada.deuFacada)
            {
                if (!enemy.findPlayer)
                {
                    facada.facaDanoInt = 1;
                    if (enemy.boss && !enemy.mataBoss)
                    {
                        gm.qntBoss--;
                        gm.qntInimigoColete++;
                        enemy.mataBoss = true;
                    }
                    arma.MorteInimigo(enemy.gameObject);
                }
                else if (enemy.findPlayer)
                {
                    if (facada.deuFacada)
                    {
                        facada.facaDanoInt = 0;
                        if (enemy.tomouFacada)
                        {

                            if (enemy.boss && !enemy.mataBoss)
                            {
                                gm.qntBoss--;
                                gm.qntInimigoColete++;
                                enemy.mataBoss = true;
                            }
                            arma.MorteInimigo(enemy.gameObject);
                            facada.deuFacada = false;
                        }
                        else if (!enemy.tomouFacada)
                        {
                            enemy.tomouFacada = true;
                            facada.deuFacada = false;
                        }
                    }
                }
            }
            else
            {
                if (facada.deuFacada)
                {
                    enemy.colete = false;
                    facada.deuFacada = false;
                }
            }
            enemy = null;
            interP = null;
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        boxcol.isTrigger = false;
    }

}
