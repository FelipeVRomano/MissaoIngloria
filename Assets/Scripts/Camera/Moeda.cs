using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moeda : MonoBehaviour
{
    [SerializeField]
    private GameObject[] moeda;
    public static int numMoeda;
    private int moedaIndex;
    [SerializeField]
    private Rigidbody[] moedaFisica;
    [SerializeField]
    private Faca faca;
    [SerializeField]
    private GameObject arma;
    public float y, z, multiplicador;
    

    [SerializeField]
    private float timeDelayMoeda;
    bool delayAtivo;
    float timer;

    [SerializeField]
    Transform maoEsquerda;
    [SerializeField]
    float moedaQtd;

    private Text moedaTxt;

    public ControleInput inputCoin;
    private void Awake()
    {
        inputCoin = GameObject.Find("ControleInput").GetComponent<ControleInput>();
    }
    void Start()
    {
        moedaTxt = GameObject.Find("txtMoeda").GetComponent<Text>();
        moedaTxt.text = moedaQtd.ToString() + (" Moedas");
        numMoeda = 0;
    }
    void Update()
    {
        // if(Input.GetButtonDown("Moeda") && !delayAtivo && moedaQtd > 0)
        if (inputCoin.inputController.Player.Moeda.triggered && !delayAtivo && moedaQtd > 0)
        {
            //jogaMoeda();
            StartCoroutine(jogaMoeda());
            //som de moeda sendo jogada
            FMODUnity.RuntimeManager.PlayOneShot("event:/Coin_Toss");

        }
        if (delayAtivo)
            timer += Time.deltaTime;
        
        if(timer >= timeDelayMoeda)
        {
            delayAtivo = false;
            timer = 0;
        }
       
        moedaTxt.text = moedaQtd.ToString();
    }

    IEnumerator jogaMoeda()
    {
        moeda[moedaIndex].transform.position = maoEsquerda.transform.position;
        moeda[moedaIndex].transform.eulerAngles = Vector3.zero;
        moedaFisica[moedaIndex].velocity = new Vector3(0f, 0f, 0f);
        moedaFisica[moedaIndex].angularVelocity = new Vector3(0f, 0f, 0f);
        moedaFisica[moedaIndex].isKinematic = false;
        // moedaFisica[moedaIndex].AddForce(new Vector3(0, y, z) * multiplicador);
        moedaFisica[moedaIndex].AddForce(transform.forward * multiplicador);
        delayAtivo = true;
        yield return new WaitForSeconds(timeDelayMoeda - 0.1f);
        numMoeda++;
        if (numMoeda >= 3)
            numMoeda = 0;
        if(moedaIndex < moeda.Length - 1)
        moedaIndex++;
        else
        {
            moedaIndex = 0;
        }
        moedaQtd--;
    }
    public void addMoeda()
    {
        moedaQtd++;
    }

   
}
