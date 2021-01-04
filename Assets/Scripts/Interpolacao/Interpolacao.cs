using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolacao : MonoBehaviour
{
    public Outline pai;
    public Action paiA;
    public Rigidbody rigidBody;
    public EnemyIA paiEnemy;
    //public EnemyTeste paiEnemy;
    public GameObject obj;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    public void ativa()
    {
        obj.SetActive(true);
        rigidBody.isKinematic = false;
    }

    public void desativa()
    {
        obj.SetActive(false);
    }
}
