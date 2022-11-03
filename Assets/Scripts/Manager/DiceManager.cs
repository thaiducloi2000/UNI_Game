using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public UNI05_GameManager manager;

    System.Random rand = new System.Random();

    private void Start()
    {
        manager = UNI05_GameManager.instance;
    }


    public void Roll()
    {
        int num_1 = rand.Next(1, 6);
        int num_2 = rand.Next(1, 6);
        Debug.Log(num_1 + " - " + num_2);
        int sum = num_1 + num_2;
        manager.Move(sum);
    }
}
