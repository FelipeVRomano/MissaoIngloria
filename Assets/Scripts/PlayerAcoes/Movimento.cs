using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimento : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    private Vector3 playerInput;

    public CharacterController Player;

    public float PlayerSpeed;
    private Vector3 movePlayer;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    public float gravity;
    public float fallVelocity;
    public float jumpForce;

   
    private bool pulando;
    private bool correndo;
    private float corrida;
    private float andarNormal;
    
    [SerializeField]
    private float corridaMultiplicador = 1.3f;


    //agachar e suas variaveis
    public bool agachado;
    [SerializeField]
    private bool podeLevantar;
    [SerializeField]
    Transform capsulaTrans;
    [SerializeField]
    private Transform head;
    float velCarregando;
    float velBase;
    bool canRun;

    //teste
    RayCastCamera cameraRay;
    bool controleCarregando;

    [SerializeField]
    private Transform[] posCameras;

    public static bool fazBarulhoCorrida;
    public static Vector3 posCorridaPlayer;

    public ControleInput inputPlayer;
    bool agachar;
    [SerializeField]
    private Faca faca;
    [SerializeField]
    private Arma arma;

    public GameObject mateIni;

    Animator anim;
    private void Awake()
    {
    //    inputPlayer = GameObject.Find("ControleInput").GetComponent<ControleInput>();
    }

    void Start()
    {
        Player = GetComponent<CharacterController>();
        andarNormal = PlayerSpeed;
        corrida = PlayerSpeed * corridaMultiplicador;
        velCarregando = PlayerSpeed / 2;
        velBase = PlayerSpeed;
        canRun = true;

        cameraRay = GameObject.Find("Camera").GetComponent<RayCastCamera>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(PlayerSpeed);
        // horizontalMove = Input.GetAxis("Horizontal");
        horizontalMove = inputPlayer.inputController.Player.Horizontal.ReadValue<float>();
        // verticalMove = Input.GetAxis("Vertical");
        verticalMove = inputPlayer.inputController.Player.Vertical.ReadValue<float>();
        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        //playerInput = new Vector3(0, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);
        movePlayer = playerInput.x * mainCamera.transform.right + playerInput.z * mainCamera.transform.forward;
        movePlayer = movePlayer * PlayerSpeed;

        if (playerInput.x != 0 || playerInput.z != 0 && !agachado)
        {
            
            //Som de passos do player
            anim.SetBool("isMoving", true);

               // if (Input.GetButton("Run"))
               if(inputPlayer.inputController.Player.Correr.ReadValue<float>() > 0.5f)
             // if(inputPlayer.Player.Correr.processors.)
                {
                    fazBarulhoCorrida = true;
                    posCorridaPlayer = transform.position ;  
                    StartCoroutine(FazBarulho());
                    if (verticalMove != 0 || horizontalMove != 0)
                    {
                    if (!pulando)
                        correndo = true;
                    }
                }
                else
                {
                    correndo = false;
                    fazBarulhoCorrida = false;
                }
         }
         else
         {
            correndo = false;
            anim.SetBool("isMoving", false);
         }

        if(playerInput.x != 0 || playerInput.z != 0)
        {
            mateIni.SetActive(false);

                faca.facaObjAnim.SetBool("andando", true);
                faca.facaObjAnim.SetBool("idle", false);
                arma.animator.SetBool("andando", true);
   
        }
        else
        {
            faca.facaObjAnim.SetBool("andando", false);
            faca.facaObjAnim.SetBool("idle", true);
            arma.animator.SetBool("andando", false);
        }
        if (correndo)
            PlayerSpeed = corrida;
        else
        {
            PlayerSpeed = andarNormal;
        }

        //gravidade
        SetGravity();
        PlayerSkills();
        Player.Move(movePlayer * Time.deltaTime);

        if(cameraRay.carregando && agachado)
        {
            diminuiVelMais();
            controleCarregando = true;
            //print("1");
        }
        else if(cameraRay.carregando || agachado)
        {
            diminuiVel();
            controleCarregando = true;
           // print("2");
        }
        else if(!cameraRay.carregando && !agachado)
        {
           //print("3");
            if(controleCarregando)
            {
                //print("4");
                voltaVel();
                controleCarregando = false;
            }
        }
    }

    void SetGravity()
    {
        if (Player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
            pulando = false;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;


        }
    }
    [SerializeField]
    private float raio;
    public void PlayerSkills()
    {
        /*
        //pulo
        if (Player.isGrounded && Input.GetButton("Jump") && !agachado)
        {
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
            pulando = true;
        }
        */
       // print(podeLevantar);
        //agachar
        if (agachado)
        {
            RaycastHit hit;
            if (Physics.Raycast(head.transform.position, head.transform.up, out hit, raio))
            {
                podeLevantar = false;
            }
            else
            {
                podeLevantar = true;
            }
            Debug.DrawLine(head.transform.position, head.transform.up, Color.red);
        }
        else
        {
            podeLevantar = true;
        }
        // if (Player.isGrounded && Input.GetButtonDown("Crouch"))
        if (Player.isGrounded && inputPlayer.inputController.Player.Agachar.triggered && !agachar)
        {
            if(podeLevantar)
            agachado = !agachado;
            if (agachado && transform.localScale.y > 0.5f)
            {
                Player.height = 0.9f;
            //    capsula.height = 1f;
                capsulaTrans.localScale = new Vector3(0.4f, 0.5f, 0.4f);
                mainCamera.transform.position = posCameras[1].position;
                canRun = false;
                agachar = true;
            }
            else
            {
                if (podeLevantar)
                {
                    Player.height = 1.8f;
               //     capsula.height = 1.8f;
                    capsulaTrans.localScale = new Vector3(0.4f, 1.75f, 0.4f);
                    mainCamera.transform.position = posCameras[0].position;
                    canRun = true;
                    agachar = true;
                }
            }
        }
        if(Player.isGrounded && inputPlayer.inputController.Player.Agachar.triggered)
        {
            agachar = false;
        }
    }

    public void diminuiVel()
    {
        PlayerSpeed = velCarregando;
        canRun = false;
    }
    public void diminuiVelMais()
    {
        PlayerSpeed = velCarregando / 1.5f;
        canRun = false;
    }
    public void voltaVel()
    {
        PlayerSpeed = velBase;
        canRun = true;
    }

    IEnumerator FazBarulho()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            fazBarulhoCorrida = false;
            
        }
    }

    public void WalkSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Walk_player");
    }
}

