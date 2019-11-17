using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Controller : MonoBehaviour
{
    public static CharacterController CharacterController;
    public static TP_Controller Instance;

    void Start()
    {
        CharacterController = GetComponent("CharacterController") as CharacterController;
        Instance = this;
    }

    void Update()
    {
        if (Camera.mainCamera == null)
            return;
        GetLocomotionInput()
    }

    void GetLocomotionInput()
    {

    }
}
