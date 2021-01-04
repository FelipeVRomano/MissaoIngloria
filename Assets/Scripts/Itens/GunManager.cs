using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunManager : MonoBehaviour
{
    [SerializeField]
    private GameObject armaPlayer;
    [SerializeField]
    private GameObject faca;
    Faca facaCod;
    [SerializeField]
    private Arma armaCodigo;
    // Start is called before the first frame update
    [SerializeField]
    Text txtArma;

    int indexConsole;
    bool controle;
    bool facaB;
    bool armaB;

    public ControleInput inputGun;



    private void Awake()
    {
      //  inputGun = GameObject.Find("ControleInput").GetComponent<ControleInput>();
    }
        void Start()
    {
        armaPlayer.SetActive(false);
        faca.SetActive(false);
        facaCod = GetComponent<Faca>();
        indexConsole = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Alpha2) && !facaCod.executando && !armaCodigo.carregando && !armaB)
        if (inputGun.inputController.Player.TrocaArmaKeyboard.ReadValue<float>() < -0.5 && !facaCod.executando && !armaCodigo.carregando && !armaB)
        {
            ativaArma();
        }
        // if (Input.GetKeyDown(KeyCode.Alpha1) && !facaCod.executando && !armaCodigo.carregando && !facaB)
        if (inputGun.inputController.Player.TrocaArmaKeyboard.ReadValue<float>() > 0.5 && !facaCod.executando && !armaCodigo.carregando && !facaB)
        {
            ativaFaca();
        }
        if (indexConsole == 0 && !controle)
        {
            //if (Input.GetButtonDown("TrocaArma") && !facaCod.executando && !armaCodigo.carregando && !facaB)
            if (inputGun.inputController.Player.TrocaArmaGamepad.triggered && !facaCod.executando && !armaCodigo.carregando && !facaB)
            {
                ativaFaca();
                controle = true;
            }
        }
        if (indexConsole == 1 && !controle)
        {
            // if (Input.GetButtonDown("TrocaArma") && !facaCod.executando && !armaCodigo.carregando && !armaB)
            if (inputGun.inputController.Player.TrocaArmaGamepad.triggered && !facaCod.executando && !armaCodigo.carregando && !armaB)
            {
                ativaArma();
                controle = true;
            }
        }
       // if (Input.GetButtonUp("TrocaArma"))
       if(!inputGun.inputController.Player.TrocaArmaGamepad.triggered)
            controle = false;
    }

    void ativaArma()
    {
        armaPlayer.SetActive(true);
        faca.SetActive(false);
        txtArma.enabled = true;
        armaB = true;
        facaB = false;
        indexConsole--;


    }
    void ativaFaca()
    {
        armaPlayer.GetComponent<Arma>().LuzDesativa();
        armaPlayer.SetActive(false);
        faca.SetActive(true);
        txtArma.enabled = false;
        facaB = true;
        armaB = false;
        indexConsole++;

    }
}
