using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Esconder : MonoBehaviour
{
    public static bool esconder;
    private Transform camPositionDestino;
    private Transform positionPorta;
    [SerializeField]
    private Vector3 camRotationDestino;
    private GameObject Player;
    private Transform cameraPos;
    private Transform posOriginalPlayer;
    private Transform posAgachadoPlayer;
    private Movimento movPlayer;
    private GameObject gun;
    private GameObject faca;
    private GunManager gunManager;
    Quaternion rotation;
    public bool Escondido;
    bool interpolando;
    CameraLook camLok;
    public ControleInput inputHide;

    public GameObject[] objetosArmario;
    bool controle;
    int facaB;
    public bool controle2;
    Vector3 savePos;
    [SerializeField]
    Volume x;
    Vignette vgn;

    public Vector2 limitsXhideC;
    public Vector2 limitsYhideC;
    public bool caixa;

    void Start()
    {
        Player = GameObject.Find("Player");
        camPositionDestino = transform.GetChild(0).GetComponent<Transform>();
        cameraPos = GameObject.Find("Camera").GetComponent<Transform>();
        posOriginalPlayer = GameObject.Find("CameraPosOriginal").GetComponent<Transform>();
        posAgachadoPlayer = GameObject.Find("CameraPosAgachada").GetComponent<Transform>();
        movPlayer = GameObject.Find("Player").GetComponent<Movimento>();
        gun = GameObject.Find("Arma");
        faca = GameObject.Find("Faca");
        gunManager = GameObject.Find("Camera").GetComponent<GunManager>();
        camLok = GameObject.Find("Camera").GetComponent<CameraLook>();
        inputHide = GameObject.Find("ControleInput").GetComponent<ControleInput>();
        x.profile.TryGet(out vgn);
    }
    void Update()
    {
        //print(controle);
        if (Escondido)
        {
            if (!inputHide.inputController.Player.Interacao.triggered)
            {
                controle = true;
                Escondido = false;
            }
      
        }
        if(controle)
        {
            if (inputHide.inputController.Player.Interacao.triggered)
            {
                voltaPlayer();
                controle2 = true;
                controle = false;
            }
       
        }
        if (controle2)
        {
            if (!inputHide.inputController.Player.Interacao.triggered)
            {
                controle2 = false;
            }
        }
    }

    public void EscondePlayer()
    {
        objetosArmario[0].SetActive(false);
        objetosArmario[1].SetActive(true);
    }
    public void somePlayer()
    {
        esconder = true;
        if (!caixa)
        {
            camLok.limitsXhide = limitsXhideC;
            camLok.rotaLado = true;
        }
        else
        {
            camLok.rotaLado = false;
        }
        camLok.limitsYhide = limitsYhideC;
        camLok.Work = true;
        camLok.camX2 = camRotationDestino.y;
        camLok.limitsX = camRotationDestino.y;
        camLok.camY2 = camRotationDestino.x;
        camLok.limitsY = camRotationDestino.x;
        objetosArmario[0].SetActive(false);
        objetosArmario[1].SetActive(true);
        cameraPos.parent = camPositionDestino;
        cameraPos.position = camPositionDestino.position;
        // cameraPos.localEulerAngles = camRotationDestino;
        savePos = Player.transform.position;
        Player.GetComponent<CharacterController>().enabled = false;
        movPlayer.enabled = false;
        Player.transform.position = new Vector3(0, -100, 0);
        vgn.active = true;

       // Player.SetActive(false);
        gunManager.enabled = false;
        if (gun.activeSelf)
        {
            gun.SetActive(false);
            facaB = 1;
        }
        else if (faca.activeSelf)
        {
            faca.SetActive(false);
            facaB = 2;
        }
        else
        {
            facaB = 0;
        }
        Escondido = true;
    }
    void voltaPlayer()
    {
        esconder = false;
        cameraPos.parent = Player.transform;
        Player.transform.position = savePos;
        Player.GetComponent<CharacterController>().enabled = true;
        movPlayer.enabled = true;
        vgn.active = false;
        //Player.SetActive(true);
        objetosArmario[0].SetActive(true);
        objetosArmario[1].SetActive(false);
        if (movPlayer.agachado)
            cameraPos.position = posAgachadoPlayer.position;
        else
        {
            cameraPos.position = posOriginalPlayer.position;
        }
        cameraPos.rotation = rotation;
        camLok.Work = false;
        gunManager.enabled = true;
        if(facaB == 2)
        {
            faca.SetActive(true);
        }
        else if(facaB == 1)
        {
            gun.SetActive(true);
        }
    }
}
