using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerBoardMovement : MonoBehaviour
{
    public Tilemap boardTiles;
    public LadderTileMechanism ladderTileMechanism;
    public SnakeTileMechanism snakeTileMechanism;
    public PlayerPositionManager playerPositionManager;
    private int moveBeforeUp, totalSquares;
    private bool isGoingRight;

    void Start(){
        moveBeforeUp = 10;
        totalSquares = 0;
        isGoingRight = true;
    }

    public void Move(int steps)
    {
        StartCoroutine(StartMove(steps));  
    }

    private IEnumerator StartMove(int steps){
        for(int i = 0; i < steps; i++)
        {
            Vector3Int direction = DetermineDirection();
            Vector3Int currentCell = boardTiles.WorldToCell(transform.position);
            if (boardTiles.HasTile(currentCell) && totalSquares <= 99)
            {
                moveBeforeUp--;
                if(moveBeforeUp == 0)
                {
                    if(isGoingRight) isGoingRight = false;
                    else isGoingRight = true;
                    Vector3Int aboveCell = currentCell + new Vector3Int(0,1,0);
                    if(boardTiles.cellBounds.Contains(aboveCell)) transform.position = boardTiles.GetCellCenterWorld(aboveCell);
                    moveBeforeUp = 10;
                    Debug.Log("Going Y");
                }
                else 
                {
                    transform.position = boardTiles.GetCellCenterWorld(currentCell + direction);
                    Debug.Log("Going X");
                }
                totalSquares++;
                yield return new WaitForSeconds(0.5f);
            } else break;
        }
        playerPositionManager.SavePosition(transform.position);
        DetermineCurrentTile(boardTiles.WorldToCell(transform.position));
    }

    private Vector3Int DetermineDirection()
    {
        return isGoingRight ? new Vector3Int(1, 0, 0) : new Vector3Int(-1, 0, 0);
    }

    private void DetermineCurrentTile(Vector3Int currentCell){
        ladderTileMechanism.CheckIfLadderTile(currentCell);
        snakeTileMechanism.CheckIfSnakeTile(currentCell);
    }
}