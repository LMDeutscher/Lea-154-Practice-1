using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture2 : MonoBehaviour
{
    public int[] list;
    public string[] Names;
    public GameObject[] Newobject;
    public Color[] Farben;
    public int score = 0;
    GameObject findsphere;
    Rigidbody rbnew;

    GameObject[] ObAll;

    // Start is called before the first frame update
    void Start()
    {
        rbnew = GetComponent<Rigidbody>();
        // why does rigidbody not work?
        //rbnew.useGravity = true;
        //rbnew.mass = 5;

        //GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Renderer>().material.color = Color.green;

        //TotalScore totalscore;
        //totalscore = GetComponent<TotalScore>();
        //totalscore.score = 100;


        GameObject.Find("Capsule").GetComponent<TotalScore>().score = 70;
        //GameObject.Find("Capsule").GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
