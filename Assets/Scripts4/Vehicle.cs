using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vehicle
{
    public float speed;
    public string color;

    public void VehicleSpeed ()
    {
        Debug.Log(speed);  //print("speed");
    }

    public void VehicleColor()
    {
        Debug.Log(color); 
    }

    //Call the default constructor
    public Vehicle()
    {
        Debug.Log("Vehicle() called");
    }

    //Create and call constructer which modifies speed

    public Vehicle(float speed)
    {
        this.speed = speed;
        Debug.Log("Vehicle(speed) called");
        Debug.Log(speed);
    }

    //modifies speed and color

    public Vehicle(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
        Debug.Log(speed + " " + color);
        Debug.Log("Vehicle(speed, color) called");
    }

    public void PrintParams()
    {
        Debug.Log("speed = " + speed);
        Debug.Log("color = " + color);
    }
}
