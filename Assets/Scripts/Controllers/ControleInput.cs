using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInput : MonoBehaviour
{
    public InputM inputController;
    void Awake()
    {
        inputController = new InputM();
    }

    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputController.Disable();
    }
}
