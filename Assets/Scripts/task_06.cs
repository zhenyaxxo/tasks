using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Vuforia;

public class task_06 : MonoBehaviour
{
    [Range(9, 100)]
    public int N = 9;

    [Range(0.2f, 10)] 
    public float offset = 1;

    [Range(0.5f, 5)]
    public float Amplitude = 0.51f;

    [Range(0, 10)]
    public float height = 2;
    
    private List<GameObject> _allObj = new List<GameObject>();
    private List<Color> _colors = new List<Color>();

    private void Awake()
    {
        setColor();
        createObj();
    }

    void setColor()
    {
        var red = new Color(255,0,0);                    _colors.Add(red);
        var orange = new Color(255, 165, 0, 255);     _colors.Add(orange);
        var yellow = new Color(255,255,0);               _colors.Add(yellow);
        var green = new Color(0,255,0);                  _colors.Add(green);
        var blue = new Color(0,255,255);                 _colors.Add(blue);
        var dark_blue = new Color(0,0,255);              _colors.Add(dark_blue);
        var purple = new Color(255,0,255);               _colors.Add(purple);
    }
    
    private void createObj()
    {
        for (int i = 0, j = 0; i < N; i++, j++)                        //Пояснительная бригада: переменная j используется для перебора цветов
        {                                                              
            var Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var material = Cube.GetComponent<Renderer>().material;
            if (j == 6)
            {
                material.color = _colors[j];
                j = 0;
            }
            else
            {
                material.color = _colors[j];
            }
            _allObj.Add(Cube);
        }
    }

    void changePosition()
    {
        for (int i = 0; i < _allObj.Count; i++)
        {
            _allObj[i].transform.position = new Vector3(i * offset, (Mathf.Sin(Time.time + i * Amplitude)) * height, 0);
        }
    }

    private void Update()
    {
        changePosition();
    }
}
