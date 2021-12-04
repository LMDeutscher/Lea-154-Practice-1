using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWork : MonoBehaviour
{

    public int[] numbers;
    public string[] Names;
    public GameObject[] objects;
    public Color[] colors; 
    // Start is called before the first frame update
    void Start()
    {
        print(numbers[2]);
        print(Names[0]);

        objects[1].GetComponent<Renderer>().material.color = colors[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
