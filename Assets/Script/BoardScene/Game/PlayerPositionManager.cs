using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionManager : MonoBehaviour
{
    [SerializeField] private PlayerPositionData playerPositionData;
    [SerializeField] private Transform spawnPoint;

    void Start(){
        if(LoadPosition() != spawnPoint.position) SavePosition(spawnPoint.position);
    }
    public void SavePosition(Vector3 position)
    {
        playerPositionData.playerPosition = position;
    }

    public Vector3 LoadPosition()
    {
        if(playerPositionData.playerPosition != Vector3.zero) return playerPositionData.playerPosition;
        else return spawnPoint.position;
    }
}
