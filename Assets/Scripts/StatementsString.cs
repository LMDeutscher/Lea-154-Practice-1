using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsString : MonoBehaviour
{
    public string Name;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Name == "Lea")
        {
            print("You're Lea");
        }

        else
        {
            print("You're not Lea");
        }
    }
}
