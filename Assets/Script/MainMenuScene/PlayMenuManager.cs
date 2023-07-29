using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuManager : MonoBehaviour
{
    public void SoloPlay()
    {
        SceneManager.LoadScene("BoardScene");
    }
}
