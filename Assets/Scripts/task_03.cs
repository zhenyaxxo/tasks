using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_03 : MonoBehaviour
{
    public int N = 5;            //Количество объектов

    [Range(1, 10)] 
    public float offset = 3f;    //Расстояние между объектами(можно менять в реал тайме)
    
    private List<GameObject> _allObj = new List<GameObject>(); //Лист всех всех объектов
    private void Awake()
    {
        CreateObj();
    }

    void CreateObj()            //Метод для создания объектов P.S. N * 2 потому что у нас должно появиться N кубов и N сфер 
    {
        for (int i = 0; i < N * 2; i++)
        {
            if (i % 2 == 0) _allObj.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
            else            _allObj.Add(GameObject.CreatePrimitive(PrimitiveType.Sphere));
        }
    }

    void ChangePosition()    //Метод для изменения позиции всех обьектов
    {
        for (int i = 0; i < _allObj.Count; i++) 
        {
            _allObj[i].transform.position = Vector3.forward * i * offset;
        }
    }
    private void Update()
    {
        ChangePosition();    //Этот метод вызывается для изменения позиции в реал тайме
    }
}