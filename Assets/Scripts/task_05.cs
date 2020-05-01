using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class task_05 : MonoBehaviour
{
    public int N = 5;
    public List<GameObject> _cubes = new List<GameObject>();

    private void Awake()
    {
        CreateObjects();
        sortObjects();
    }

    void CreateObjects()
    {
        for (int i = 0; i < N; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            do
            {
                obj.transform.position = setRandomPosition();
            } while (checkPosition(obj.transform.position.x));
            _cubes.Add(obj);
        }
    }

    bool checkPosition(float _position)
    {
        foreach (var obj in _cubes)
        {
            if (obj.transform.position.x == _position)
            {
                return true;
            }
        }

        return false;
    }
    
    Vector3 setRandomPosition()
    {
        return new Vector3(Random.Range(0, N * 2), 0, Random.Range(0, N * 2));
    }

    void sortObjects()
    {
        for (int i = 1; i < _cubes.Count; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if(_cubes[j].transform.position.x < _cubes[j-1].transform.position.x)
                {
                    var temp = _cubes[j];
                    _cubes[j] = _cubes[j - 1];
                    _cubes[j - 1] = temp;
                }
            }
        }
    }
}