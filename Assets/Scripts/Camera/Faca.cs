using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faca : MonoBehaviour
{
    [SerializeField]
    GameObject arma;
    [SerializeField]
    private Animator facaAnim;

    [HideInInspector]
    public bool executando;

    public bool deuFacada;
    public ControleInput inputKnife;

    FacaDano facaObject;
    [SerializeField]
    private Transform facaObj;
    private Vector3 facaPosOriginal;
    [SerializeField]
    private Transform positionDesejadaAnim;
    public Animator facaObjAnim;
    public int facaDanoInt;
    private void Awake()
    {
        inputKnife = GameObject.Find("ControleInput").GetComponent<ControleInput>();
        facaObject = GameObject.Find("Faca").GetComponent<FacaDano>();
    }
    void Update()
    {
        if (inputKnife.inputController.Player.Atirar.triggered && !executando)
            StartCoroutine(facada());
    }
    IEnumerator facada()
    {
        facaPosOriginal = facaObj.localPosition;
        facaAnim.SetTrigger("facada");
        //Som de facada
        facaObject.valor = 0;
        RayCastCamera.podeSeEsconder = false;
        executando = true;
        deuFacada = true;
        yield return new WaitForSeconds(0.1f);
        if (facaDanoInt == 0)
            facaObjAnim.SetTrigger("facaHit");
        else if (facaDanoInt == 1)
        {
            facaObjAnim.SetTrigger("facaMata");
            facaObj.localPosition = positionDesejadaAnim.localPosition;
        }
        yield return new WaitForSeconds(0.5f);
        facaObj.localPosition = facaPosOriginal;
        yield return new WaitForSeconds(0.6f);
        deuFacada = false;
        RayCastCamera.podeSeEsconder = true;
        executando = false;
    }
}
