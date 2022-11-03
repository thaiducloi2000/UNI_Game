using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNI05_GameManager : MonoBehaviour
{
    public static UNI05_GameManager instance;
    [SerializeField] public GameObject StartBlock;
    [SerializeField] public List<Transform> Blocks;
    [SerializeField] public GameObject Chessboard;
    public MoveManagment moveManagment;
    [SerializeField] public GameObject Player;
    public int diceResult = 0;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("There are more  than 1 UNI05_GameManager instance");
            return;
        }
        loadBlock();
        instance = this;
    }

    private void Start()
    {
        SpawnPlayer();
        moveManagment = MoveManagment.instance;
    }

    public void loadBlock()
    {
        this.Blocks = new List<Transform>();
        for(int i = 0; i < Chessboard.transform.childCount; i++)
        {
            Blocks.Add(Chessboard.transform.GetChild(i).gameObject.transform);
        }
    }


    public void resetDice()
    {
        this.diceResult = 0;
    }

    public void SpawnPlayer()
    {
        Transform startPosition = this.StartBlock.gameObject.transform;
        Vector3 pos = new Vector3(startPosition.position.x, 0.6f, startPosition.position.z);
        this.Player = Instantiate(Player, pos, Quaternion.identity);
        //Debug.Log("Current X : " + player.transform.position.x);
        //Debug.Log("Current Z : " + player.transform.position.z);
    }

    public void Move(int numOfDice)
    {
        moveManagment.Move(Player,numOfDice,Blocks);
    }
}
