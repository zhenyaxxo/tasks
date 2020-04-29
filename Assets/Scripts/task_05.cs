using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class task_05 : MonoBehaviour
{
    //Кубы будем распологать по оси X

    public int N = 5;
    public int i = 0;
    private bool Error = false;            //Переменная для того чтобы понять есть ли куб на координате или нет
    private List<int> _usedCoord = new List<int>();
    private void Start()
    {
        for (; i < N; i++)
        {
            int x = Random.Range(0, N * 2);
            for (int j = 0; j < _usedCoord.Count; j++)
            {
                if (_usedCoord[j] == x)
                {
                    Error = true;
                    break;
                }
                else Error = false;
            }

            if (Error == false)           //Если такой координаты нет в листе, то тогда создай куб, если есть, то пройди еще раз цикл с тем же значением i
            {
                Vector3 temp = new Vector3(x, 0, 0);
                GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Cube.transform.position = temp;
                _usedCoord.Add(x);
            }
            else i--;
        }
    }
}