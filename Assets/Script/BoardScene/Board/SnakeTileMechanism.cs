using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SnakeTileMechanism : MonoBehaviour
{
    [SerializeField] private Tilemap boardTiles, snakeTiles;
    
    public void CheckIfSnakeTile(Vector3Int currentCell){
        TileBase snakeTile = snakeTiles.GetTile(currentCell);
        if(snakeTile != null)
        {
            Debug.Log("Snake Tile!");
        }
    }
}
