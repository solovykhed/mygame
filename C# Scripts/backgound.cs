using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgound : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "DeadZone")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 20f);
        }
    }
}
