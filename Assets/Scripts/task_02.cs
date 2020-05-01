using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_02 : MonoBehaviour
{
    public int N = 3;
    [Range(1, 10)] 
    public float offset = 3f;

    private List<Transform> cubeList = new List<Transform>();
    private void Awake()
    {
        for (int i = 0; i < N; i++)                    //Создаем кубы и забираем его trasform в наш лист
        {
            cubeList.Add(GameObject.CreatePrimitive(PrimitiveType.Cube).transform);
        }
    }

    private void Update()
    {
        for (int i = 0; i < cubeList.Count; i++)
        {
            cubeList[i].position = Vector3.forward * i * offset;
        }
    }
}
