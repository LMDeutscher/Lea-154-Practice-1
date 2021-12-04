using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{
    public GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject oo in obj)
        {
            Destroy(oo);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
