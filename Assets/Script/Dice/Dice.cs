using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public static int Roll(){
        return Random.Range(1,6 + 1); // returns between 1-6.
    }
}
