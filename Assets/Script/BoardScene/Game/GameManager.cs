using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private LadderTileMechanism ladderMechanism;
    [SerializeField] private SnakeTileMechanism snakeMechanism;
    [SerializeField] private Tilemap boardTiles;
    [SerializeField] private PlayerPositionManager playerPositionManager;
    void Awake(){
        player.GetComponent<PlayerBoardMovement>().boardTiles = boardTiles;
        player.GetComponent<PlayerBoardMovement>().ladderTileMechanism = ladderMechanism;
        player.GetComponent<PlayerBoardMovement>().snakeTileMechanism = snakeMechanism;
        player.GetComponent<PlayerBoardMovement>().playerPositionManager = playerPositionManager;
        GameObject newPlayer = Instantiate(player, playerPositionManager.LoadPosition(), Quaternion.identity);
        gameObject.GetComponent<DiceHandler>().player = newPlayer;
    }

    void Update(){
        if(Input.GetKey(KeyCode.P)) 
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenuScene");
        }
    }

}
