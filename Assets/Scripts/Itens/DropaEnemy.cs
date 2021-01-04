using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropaEnemy : MonoBehaviour
{
    [SerializeField]
    private LayerMask layer;
    [SerializeField]
    private float distRay;
    [SerializeField]
    private Transform[] transPos;
    public Transform posReal;
    [SerializeField]
    bool direitaOcupada, esquerdaOcupada, trasOcupada, frenteLiberada;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        /*
        if (Physics.Raycast(transform.position, transform.right, out hit, distRay, layer))
        {
            if (hit.collider != null)
            {
                direitaOcupada = true;
            }
        }
        else
        {
            direitaOcupada = false;
        }
        if(direitaOcupada)
        {
            if(Physics.Raycast(transform.position, -transform.right, out hit, distRay, layer))
            {
                if(hit.collider != null)
                {
                    esquerdaOcupada = true;
                }
            }
            else
            {
                esquerdaOcupada = false;
            }
        }
        if (esquerdaOcupada && direitaOcupada)
        {
        */
            if(Physics.Raycast(transform.position, -transform.forward, out hit, distRay, layer))
            {
                if (hit.collider != null)
                    trasOcupada = true;
            }
            else
            {
                trasOcupada = false;
            }
        if(trasOcupada)
        {
            posReal = transPos[1];
        }
        else
        {
            posReal = transPos[0];
        }
    }
}
