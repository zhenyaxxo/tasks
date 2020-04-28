using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace task_05
{
    public class task_05 : MonoBehaviour
    {
        //Кубы будем распологать по оси X

        public int N = 5;
        public int i = 0;

        private void Start()
        {
            for (; i < N; i++)
            {
                Vector3 temp = new Vector3(Random.Range(0, N * 2), 0, 0);
                GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Cube.transform.position = temp;
                BoxCollider CubeCollider = Cube.GetComponent<BoxCollider>();
                CubeCollider.isTrigger = true;
                Cube.AddComponent<task_05_trigger>();
            }
        }
    }
}