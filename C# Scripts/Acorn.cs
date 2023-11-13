using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)           
    {
        float RandX = Random.Range(-1.7f, 1.7f);                // задаем новую позицию по х
        float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f); // и новую позицию по у

        transform.position = new Vector3(RandX, RandY, 0);      // перемещаем объект по заданным координатам
    }
}
