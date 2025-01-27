using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);
            GameObject.Find("sprite");
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);
            GameObject.Find("sprite");
        }
    
    }
}
