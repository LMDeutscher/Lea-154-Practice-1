using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorsScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Vehicle MyVehicle2 = new Vehicle();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vehicle MyVehicle2 = new Vehicle();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vehicle MyVehicle2 = new Vehicle(6.6f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vehicle MyVehicle2 = new Vehicle(6.6f, "Green");
        }
    }
}
