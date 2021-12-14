using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position = transform.position + new Vector3(0, 0.01f, 0);
            transform.position += new Vector3(0, 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right*speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed,0,0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(speed, 0, speed);
            transform.localScale += new Vector3(0, speed, 0);
        }

    }
}
