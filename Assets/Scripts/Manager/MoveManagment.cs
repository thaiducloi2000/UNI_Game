using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveManagment : MonoBehaviour
{
    public static MoveManagment instance;
    public UNI05_GameManager gameManager;
    public GameObject dealIn4;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There are more  than 1 MoveManagement instance");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        this.dealIn4.SetActive(false);
        gameManager = UNI05_GameManager.instance;
    }

    public void Move(GameObject player, int move, List<Transform> listblock)
    {
        int pos = 0;
        for (int i = 0; i < listblock.Count; i++)
        {
            if (player.transform.position.x == listblock[i].transform.position.x && player.transform.position.z == listblock[i].transform.position.z)
            {
                pos = i;
            }
        }
        if(pos+move >= listblock.Count)
        {
            move = (pos + move) - listblock.Count;
            pos = 0;
        }
        player.transform.position = new Vector3(listblock[pos+move].transform.position.x,0.6f, listblock[pos + move].transform.position.z);
        Block block = listblock[pos+move].transform.gameObject.GetComponent<Block>();
        if(block.action == Block.Action.Opportunity)
        {
            this.dealIn4.SetActive(true);
            Deal deal = this.dealIn4.GetComponent<Deal>();
            Opportunity op = gameManager.opportunities;
            deal.setTextDeal(op.Opportunity_name,op.Description,op.cost.ToString(),op.Dividend.ToString(),"$"+op.MinTradingRange+" ~ $"+op.MaxTradingRange,op.SharesOwned.ToString());
        }
    }

}
