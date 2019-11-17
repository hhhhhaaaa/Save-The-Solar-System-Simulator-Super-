using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Motor : MonoBehaviour
{
    public static TP_Motor Instance;

    public float MoveSpeed = 10f;

    public Vector3 MoveVector { get; set;  }

    void Awake()
    {
        Instance = this;
    }

    public void UpdateMotor()
    {
        SnapAlignCharacterWithCamera();
        ProcessMotion();
    }

    void ProcessMotion()
    {
        MoveVector = transform.TransformDirection(MoveVector);

        if (MoveVector.magnitude > 1)
        {
            MoveVector = Vector3.Normalize(MoveVector);
        }

        MoveVector *= MoveSpeed;

        MoveVector *= Time.deltaTime;

        TP_Controller.CharacterController.Move(MoveVector);
    }

    void SnapAlignCharacterWithCamera()
    {
        if (MoveVector.x != 0 || MoveVector.z != 0)
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
