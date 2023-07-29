using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceHandler : MonoBehaviour
{
    [SerializeField] private Text announce;
    public GameObject player;    
    [SerializeField] private Dice dice;

    public void TakeTurn(){
        int obtainedNumber = Dice.Roll();
        announce.text = "Rolled Number: " + obtainedNumber;
        player.GetComponent<PlayerBoardMovement>().Move(obtainedNumber);
    }


    
}
