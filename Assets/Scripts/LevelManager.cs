using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject sprite;
    
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            LoadSceneMainMenu();
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            LoadGameplayScene();
        }
    
    }

    void LoadSceneMainMenu()
    {
        SceneManager.LoadScene(0);

        spawnpoint = GameObject.Find("SpawnPoint_MainMenu");
        
        sprite.transform.position = spawnpoint.transform.position;
    }

    void LoadGameplayScene()
    {
        SceneManager.LoadScene(1);
        
        spawnpoint = GameObject.Find("Spawnpoint_Gameplay");

        sprite.transform.position = spawnpoint.transform.position;

    }



}
