using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJudge : MonoBehaviour
{
    [SerializeField] private PlayerPositionManager playerPositionManager;
    [SerializeField] private GameObject player;

    public void PlayerWin()
    {
        SceneManager.LoadScene("BoardScene");
        Instantiate(player, playerPositionManager.LoadPosition(), Quaternion.identity);
    }
}
