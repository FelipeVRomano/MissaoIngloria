using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

    private float timer;
    [SerializeField]
    private float tempTimer;
    [HideInInspector]
    public bool adcTimer;

    //MeshRenderer meshEnemy;
    Outline meshEnemy;
    [SerializeField]
    bool teste;

    void Start()
    {
        if (teste)
        {
            meshEnemy = GetComponent<Outline>();
        }
        timer = 0;
    }

    void Update()
    {
        if (adcTimer)
            timer += Time.deltaTime;

        if (timer > tempTimer)
            tiraHighlight();
    }

    public void highlightEnemy()
    {
        //Som de mark
        FMODUnity.RuntimeManager.PlayOneShot("event:/Marcar");

        adcTimer = true;
        if(meshEnemy != null)
        meshEnemy.enabled = true;
    }

    public void tiraHighlight()
    { 
        adcTimer = false;
        timer = 0;
        meshEnemy.enabled = false;
    }
}

