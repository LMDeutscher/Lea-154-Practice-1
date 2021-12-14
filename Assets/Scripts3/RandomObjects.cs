using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            int randnumb = Random.Range(0, obj.Length);
            Instantiate(obj[randnumb], transform.position, Quaternion.identity);
        }
    }
}
