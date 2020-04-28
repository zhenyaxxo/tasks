using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_03 : MonoBehaviour
{
    public int N = 5;
    private Vector3 _position = new Vector3(0, 0, 0);
    private int temp = 0; //Переменная чтобы проверить какой объект должен создаваться(куб или сфера);

    private void Awake()
    {
        for (int i = 0; i < N; i++)
        {
            if (temp == 0)
            {
                GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Cube.transform.position = new Vector3(_position.x + 3, _position.y, _position.z);
                _position = new Vector3(Cube.transform.position.x, Cube.transform.position.y,
                    Cube.transform.position.z);
                temp = 1;
                continue;
            }

            if (temp == 1)
            {
                GameObject Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Sphere.transform.position = new Vector3(_position.x + 3, _position.y, _position.z);
                _position = new Vector3(Sphere.transform.position.x, Sphere.transform.position.y,
                    Sphere.transform.position.z);
                temp = 0;
                continue;
            }
        }
    }
}