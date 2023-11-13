﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornGenerate : MonoBehaviour
{
    public GameObject acornPrefab;       // переменная для префаба

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();    // нам нужен новый вектор

        for (int i = 0; i < 10; i++)                // цикл For, который выполняется 10 раз
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);  // позиция по оси х
            SpawnerPosition.y += Random.Range(2f, 4f);      // позиция по оси у 

            Instantiate(acornPrefab, SpawnerPosition, Quaternion.identity);  // создание префабов
        }
    }
}
