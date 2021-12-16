using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesWork : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneLoaderName();
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            SceneLoaderIndex();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneLoaderPublic();
        }
    }

    void SceneLoaderName()
    {
        SceneManager.LoadScene("Level2");
        print("loaded by name");
    }

    void SceneLoaderIndex()
    {
        SceneManager.LoadScene(0);
        print("loaded by index");
    }

    void SceneLoaderPublic()
    {
        SceneManager.LoadScene(index);
        print("loaded by public");
    }
}
