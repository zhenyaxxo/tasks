using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_01 : MonoBehaviour
{
    private SphereCollider _sphere;
    private GameObject _firstCube;
    private GameObject _secondCube;

    private void Awake()
    {
        _sphere = FindObjectOfType<SphereCollider>();
        _sphere.name = "ITS_SPHERE";
        _secondCube = GameObject.FindWithTag("Cube");
        _secondCube.name = "CUBE_SECOND";
        _firstCube = GameObject.Find("first");
        _firstCube.name = "CUBE_FIRST";
    }
}
