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
        //Find Cube and change mass, gravity

        //GameObject.Find("Cube").GetComponent<Rigidbody>().useGravity = true;

        rb = GameObject.Find("Cube").GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.mass = 5;


        //Hide objects with tag hide

        //GameObject.FindWithTag("Hide").SetActive(false);

        go = GameObject.FindWithTag("Hide");
        go.SetActive(false);


        //Destroy objects with destroy tag

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
