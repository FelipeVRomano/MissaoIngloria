using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity;

    [SerializeField]
    private Transform playerBody;

    float xRotation = 0f;

    [SerializeField]
    float delayTime;

    bool delay;

    [SerializeField]
    private Vector2 camLimit;

    public bool Work;
    [HideInInspector]
    public float camX2;
    [HideInInspector]
    public float limitsX;
    [HideInInspector]
    public float limitsY;
    [HideInInspector]
    public float camY2;
    float xRotation2x;
    float xRotation2y;
    Vector2 limitsFinalX;
    Vector2 limitsFinalY;
    [HideInInspector]
    public Vector2 limitsXhide;
    [HideInInspector]
    public Vector2 limitsYhide;
    public ControleInput inputCamera;
    public bool rotaLado;
    [SerializeField]
    private Slider UIValue;
    private void Awake()
    {
       // inputCamera = GameObject.Find("ControleInput").GetComponent<ControleInput>();
    }

 
    void Start()
    {
        delay = true;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (delay)
        {
            delayTime -= Time.deltaTime;
        }
        
        if (delayTime <= 0)
        {
            delay = false;
            if (!Work)
            {
                
                //float camX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                float camX = inputCamera.inputController.Player.MouseX.ReadValue<float>() * mouseSensitivity * Time.deltaTime;
                //float camY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
                float camY = inputCamera.inputController.Player.MouseY.ReadValue<float>() * mouseSensitivity * Time.deltaTime;

                xRotation -= camY;
                xRotation = Mathf.Clamp(xRotation, camLimit.x, camLimit.y);

                transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
                playerBody.Rotate(Vector3.up * camX);
            }
            else if(Work)
            {
                if (rotaLado)
                {
                    limitsFinalX.x = limitsX - limitsXhide.x;
                    limitsFinalX.y = limitsX + limitsXhide.y;
                }

                limitsFinalY.x = limitsY - limitsYhide.x;
                limitsFinalY.y = limitsY + limitsYhide.y;
                //camX2 += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                camX2 += inputCamera.inputController.Player.MouseX.ReadValue<float>() * mouseSensitivity * Time.deltaTime;
                //camY2 -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
                camY2 -= inputCamera.inputController.Player.MouseY.ReadValue<float>() * mouseSensitivity * Time.deltaTime;
                if (rotaLado)
                {
                    xRotation2x = camX2;
                    xRotation2x = Mathf.Clamp(xRotation2x, limitsFinalX.x, limitsFinalX.y);
                }
                else
                {
                    xRotation2x = camX2;
                }
                xRotation2y = camY2;
                xRotation2y = Mathf.Clamp(xRotation2y, limitsFinalY.x, limitsFinalY.y);
                transform.rotation = Quaternion.Euler(xRotation2y, xRotation2x, 0);
            }
        }
    }

    public void MouseSensitivity()
    {
        mouseSensitivity = UIValue.value;
    }
}
