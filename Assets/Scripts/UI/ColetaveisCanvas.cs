using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaveisCanvas : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    public GameObject esse;
    public bool scale;

    void Start()
    {
        mainCamera = GameObject.Find("Camera").GetComponent<Camera>();
    }

    void Update()
    {
        gameObject.transform.LookAt(mainCamera.transform);

        if (scale == true)
        {
            if (!esse.activeSelf)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
