using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSize : MonoBehaviour
{
    private int skipTurn;
    private float downSizeAmount;

    public int SkipTurn { get => skipTurn; set => skipTurn = value; }
    public float DownSizeAmount { get => downSizeAmount; set => downSizeAmount = value; }
}
