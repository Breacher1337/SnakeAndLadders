using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceHandler : MonoBehaviour
{
    [SerializeField] private Text announce;
    [SerializeField] private PlayerBoardMovement player;    
    [SerializeField] private Dice dice;

    public void TakeTurn(){
        int obtainedNumber = Dice.Roll();
        announce.text = "Rolled Number: " + obtainedNumber;
        player.Move(obtainedNumber);
    }


    
}
