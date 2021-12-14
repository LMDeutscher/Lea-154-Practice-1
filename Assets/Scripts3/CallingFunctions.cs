using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingFunctions : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("NexFunc", 2f);
        InvokeRepeating("NewFunc", 3f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //on my laptop there is no middle mouse button
        {
            CancelInvoke("NewFunc");
        }
    }

    void NewFunc()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
