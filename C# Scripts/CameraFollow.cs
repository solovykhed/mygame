using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform BoarPos; 

    void Update()
    {
        if (BoarPos.position.y > transform.position.y) 
        {
            transform.position = new Vector3(transform.position.x, BoarPos.position.y, transform.position.z); 
        }
    }
}
