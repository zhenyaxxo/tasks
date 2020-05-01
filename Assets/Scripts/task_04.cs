using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_04 : MonoBehaviour
{
    public int N = 5;                                             //Количество элементов
    [Range(1, 10)] 
    public float height = 2f;                                     //Переменная для изменения расстояния от сферы до куба
    
    [Range(1, 10)] 
    public float offset = 3f;                                     //Расстояние между элементами
    private List<GameObject> _cube = new List<GameObject>();      //Лист объектов кубов(если задача измениться, можно будет работать отдельно с кубами)
    private List<GameObject> _sphere = new List<GameObject>();    //Лист объектов сфер(если задача измениться, можно будет работать отдельно с сферами)
    private void Awake()
    {
        CreateObj();
    }

    void CreateObj()        //Метод для создания объектов
    {                       
        for (int i = 0; i < N * 2; i++)
        {
            if (i < N) _cube.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
            else       _sphere.Add(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            
        }
    }

    void changePosition()    // Метод для изменения позиций
    {
        for (int i = 0; i < _cube.Count; i++)
        {
            _cube[i].transform.position = Vector3.forward * i * offset;
        }

        for (int i = 1; i <= _sphere.Count; i++)
        {
            _sphere[i - 1].transform.position = Vector3.forward * (i -1) * offset + Vector3.up * height * i;
        }
    }

    private void Update()
    {
        changePosition();
    }
}