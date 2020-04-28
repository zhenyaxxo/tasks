using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_02 : MonoBehaviour
{
    public int N = 1;
    private Vector3 _position = new Vector3(0, 0, 0);
    private void Awake()
    {
        for (int i = 0; i < N; i++)
        {
            GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position = new Vector3(_position.x + 3, _position.y, _position.z);
            _position = new Vector3(Cube.transform.position.x, Cube.transform.position.y, Cube.transform.position.z);
        }
    }
}
