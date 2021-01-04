using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class HUDPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject Mapa, PauseM;
    bool controlaMapa;
    bool controlaPause;
    public ControleInput inputUI;

    public float inputIndex;
    public LocalizaPlayer mapaLocal;

    //Bool para ver se esta pausado com o menu na tela
    bool isPaused;

    //Controla os efeitos sonoros do pause
    FMOD.Studio.Bus lowPass;
    FMOD.Studio.Bus music;
    public float volumePass;
    public float volumeMusic;
    public bool menuOptions;
    [SerializeField]
    private GameObject menuOpcao;

    [SerializeField]
    private GameObject menuPause;

    
    public static bool ativaMapa;
    void Awake()
    {
      //  Mapa = GameObject.Find("Mapa");
      //  PauseM = GameObject.Find("PauseMenu");
        
      //  inputUI = GameObject.Find("ControleInput").GetComponent<ControleInput>();
        lowPass = FMODUnity.RuntimeManager.GetBus("bus:/LowPass");
        music = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music/Combat");
    }

    void Start()
    {
        Mapa.SetActive(false);
        PauseM.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        volumePass = 0f;
        volumeMusic = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Controla o volume dos efeitos de audio
        lowPass.setVolume(volumePass);
        music.setVolume(volumeMusic);

      //  if (Input.GetButtonDown("Mapa"))
       if(inputUI.inputController.UI.Mapa.triggered && !controlaPause && ativaMapa)
      // if(inputUI.Player.Mapa.performed += context 
        {
            controlaMapa = !controlaMapa;
            ativar(controlaMapa, Mapa, 0);
            mapaLocal.AtualizaMapa();
        }
       if(inputUI.inputController.UI.Pause.triggered && !controlaMapa)
        {
            if(!menuOptions)
            chamAcao();
            else
            {
                menuOpcao.SetActive(false);
                menuPause.SetActive(true);
                menuOptions = false;
            }
        }

       

    }

    public void ativar(bool setMap, GameObject ativado, float controller)
    {
        //  setMap = !setMap;        
        if(setMap)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            inputUI.inputController.Player.Disable();
      //   inputUI.ui
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            // inputUI.Player.Enable();
            inputUI.inputController.Player.Enable();
        }
        ativado.SetActive(setMap);
        if (Time.timeScale > 0) Time.timeScale = 0;
            else
            {
                Time.timeScale = 1;
            }
    }
    public void MenuOptions(int x)
    {
        if(x == 0)
        menuOptions = true;
        else
        {
            menuOptions = false;
        }
    }

    public void LoadScene(int x)
    {
        SceneManager.LoadScene(x);
    }
    public void chamAcao()
    {
        //Coisas necessarias para o pause e os sons
        if (!isPaused)
        {
            isPaused = true;
            //Som de pause
            FMODUnity.RuntimeManager.PlayOneShot("event:/Pause");
            volumePass = 1f;
            volumeMusic = 0f;
        }
        else
        {
            isPaused = false;
            //Som de unpause
            FMODUnity.RuntimeManager.PlayOneShot("event:/Unpause");
            volumePass = 0f;
            volumeMusic = 1f;
        }

        controlaPause = !controlaPause;
        ativar(controlaPause, PauseM, 1);
    }
}

