using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    public int control = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Capsule").GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        switch (control)
        {
            case 1:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 3:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}
