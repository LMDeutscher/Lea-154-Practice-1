using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObject : MonoBehaviour
{
    Rigidbody rb;
    GameObject go;
    GameObject[] obj;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Cylinder").GetComponent<Rigidbody>().useGravity = true;

        rb = GameObject.Find("Cylinder").GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.mass = 5;

        //GameObject.Find("Sphere").GetComponent<Renderer>().material.color = Color.red;

        //GameObject.FindWithTag("Hide").SetActive(false);

        go = GameObject.FindWithTag("Hide");
        go.SetActive(false);

        obj = GameObject.FindGameObjectsWithTag("Destroy");
        foreach(GameObject newobj in obj)
        {
            Destroy(newobj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
