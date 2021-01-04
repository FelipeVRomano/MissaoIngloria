using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public List<string> textUI;
    private Text texto;
    bool ativadoG, ativadoK, ativado;
    public ControleInput con;
    bool executando;


    void Start()
    {
        texto = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ativado)
        {
            if (DeviceChange.keyBoard && ativadoG)
            {
                atualizaTextUI("", textUI[1]);
                ativado = false;
            }
            if (!DeviceChange.keyBoard && ativadoK)
            {
                atualizaTextUI(textUI[0], "");
                ativado = false;
            }
        }

        //if (con.inputController.Player.MarcarInimigos.triggered)
        //    DeviceChange.keyBoard = !DeviceChange.keyBoard;
    }

    public void atualizaTextUI(string textUIG, string textUIK)
    {
        //  texto.enabled = true;
        if (!ativado)
        {
            textUI.Clear();
            if (DeviceChange.keyBoard)
            {
                texto.text = textUIK;
                ativadoK = true;
                ativadoG = false;
            }
            else
            {
                texto.text = textUIG;
                ativadoG = true;
                ativadoK = false;
            }
            textUI.Add(textUIG);
            textUI.Add(textUIK);
        }
        ativado = true;
    }
    public void desativaTxt()
    {
        textUI.Clear();
        texto.text = "";
        ativado = false;
        ativadoG = false;
        ativadoK = false;
    }
}
