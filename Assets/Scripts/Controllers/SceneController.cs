using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public GameObject final;
    public ControleInput inputUI;

    public GameObject backSound;
    private bool finalController;

    public bool timer;
    public float timercd;

    // Start is called before the first frame update
    void Start()
    {
        if(Time.timeScale == 0)
        Time.timeScale = 1;

  
    }

    void Update()
    {
        if (timer)
        {
            timercd += Time.deltaTime;
        }
           

        if (timercd > 10)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void MudaTela(string tela)
    {
        SceneManager.LoadScene(tela);
    }

    public void Sair()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;

            final.SetActive(true);
            
            inputUI.inputController.Player.Disable();
            inputUI.inputController.UI.Disable();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            // Invoke("MudaCena",0.5f);
        }
    }
    
    public void MudaCena()
    {
        SceneManager.LoadScene(0);
    }
    public void ChamaFinal()
    {
        if (finalController == false)
        {
            Time.timeScale = 1;
            backSound.SetActive(true);
            finalController = true;
            timer = true;
        }

    }



}
