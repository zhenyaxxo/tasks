using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_04 : MonoBehaviour
{
    public int N = 5;
    private Vector3 _positionCube = new Vector3(0, 0, 0);

    private void Awake()
    {
        for (int i = 0; i < N; i++)                              //Создаем первый ряд и сохраняем последнюю координату в _positionCube
        {
            GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position = new Vector3(_positionCube.x + 3, _positionCube.y, _positionCube.z);
            _positionCube = new Vector3(Cube.transform.position.x, Cube.transform.position.y,
                Cube.transform.position.z);
        }

        for (int i = 0; i < N; i++)                               //Создаем второй ряд(сфер) в обратном порядке
        {
            GameObject Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Sphere.transform.position = new Vector3(_positionCube.x, _positionCube.y + 2, _positionCube.z);
            _positionCube = new Vector3(Sphere.transform.position.x - 3, Sphere.transform.position.y,
                Sphere.transform.position.z);
        }
    }
}