using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionManager : MonoBehaviour
{
    [SerializeField] private PlayerPositionData playerPositionData;

    public void SavePosition(Vector3 position)
    {
        playerPositionData.playerPosition = position;
    }

    public Vector3 LoadPosition()
    {
        return playerPositionData.playerPosition;
    }
}
