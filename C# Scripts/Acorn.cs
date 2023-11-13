using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)           
    {
        float RandX = Random.Range(-1.7f, 1.7f);                // ������ ����� ������� �� �
        float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f); // � ����� ������� �� �

        transform.position = new Vector3(RandX, RandY, 0);      // ���������� ������ �� �������� �����������
    }
}
