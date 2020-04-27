using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMinimap : MonoBehaviour
{
    public Transform player;
    public Camera mainCamera;
    public bool rotateWithPlayer;

    void Start()
    {
        SetPosition();
        SetPosition();
    }
    void LateUpdate()
    {
        if( player != null)
        {
            SetPosition();

            if(rotateWithPlayer && mainCamera)
            {
                SetRotation();
            }
        }
    }
    void SetPosition()
    {
        var newPos = player.position;
        newPos.y = transform.position.y;
        newPos.z = -10f;

        transform.position = newPos;
    }
    void SetRotation()
    {
        transform.rotation = Quaternion.Euler(90f, mainCamera.transform.eulerAngles.y, 0f);
    }
}