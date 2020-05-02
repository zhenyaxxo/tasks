using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_08 : MonoBehaviour
{
    [Range(1.7f, 10)] public float offset = 2;

    [Range(1.5f, 10)] public float height = 1.5f;

    [Range(0, 1000)] public float speed = 20f;

    private GameObject[,] _cubes = new GameObject[10, 10];

    private void Start()
    {
        createObj();
    }

    void createObj()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                _cubes[i, j] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                _cubes[i, j].transform.position = Vector3.forward * j * offset + Vector3.up * i * height;
            }
        }
    }

    void rotation()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (j == 9 - i)
                {
                    _cubes[i, j].transform.Rotate(Vector3.right * (Time.deltaTime * speed));
                }
                if (j > 9 - i)
                {
                    _cubes[i, j].transform.Rotate(Vector3.up * (Time.deltaTime * speed));
                    _cubes[i, j].GetComponent<Renderer>().material.color = Color.red;
                }

                if (j < 9 - i)
                {
                    _cubes[i, j].transform.Rotate(Vector3.up * -(Time.deltaTime * speed));
                    _cubes[i, j].GetComponent<Renderer>().material.color = Color.blue;
                }

                _cubes[i, j].transform.position = Vector3.forward * j * offset + Vector3.up * i * height;
            }
        }
    }

    private void Update()
    {
        rotation();
    }
}