using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerPositionData", menuName = "ScriptableObjects/PlayerPositionData")]
public class PlayerPositionData : ScriptableObject
{
    public Vector3 playerPosition;
}
