using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarulhoMoeda : MonoBehaviour
{
    public static bool fazBarulhoMoeda;
    private Vector3 paiPosicao;

    void Start()
    {
        paiPosicao = GameObject.Find("Moedas").GetComponent<Transform>().position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Respawn"/*Tag do Chão*/))
        {
            
            fazBarulhoMoeda = true;
            print("Faz barulho moeda " + fazBarulhoMoeda);
            StartCoroutine(FazBarulho());

            //Som de moeda caindo
            SendMessage("Play");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            //if(other.gameObject.GetComponent<RaycastTeste>().escutandoMoeda)
            //transform.position = paiPosicao;
        }
    }
    IEnumerator FazBarulho()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            fazBarulhoMoeda = false;
        }
    }
}