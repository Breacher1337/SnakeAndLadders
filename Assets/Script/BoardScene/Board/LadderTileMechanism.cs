using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class LadderTileMechanism : MonoBehaviour
{
    [SerializeField] private Tilemap boardTiles, ladderTiles;
    
    public void CheckIfLadderTile(Vector3Int currentCell){
        TileBase ladderTile = ladderTiles.GetTile(currentCell);
        if(ladderTile != null)
        {

            SceneManager.LoadScene("ParkourScene");
            Debug.Log("Ladder Tile!");
        }
    }
}
