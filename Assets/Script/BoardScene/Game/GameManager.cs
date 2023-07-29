using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Update(){
        if(Input.GetKey(KeyCode.P)) 
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenuScene");
        }
    }

}
