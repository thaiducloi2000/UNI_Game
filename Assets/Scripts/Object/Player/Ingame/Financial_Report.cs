using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Financial_Report : MonoBehaviour
{
    private string id;
    private string player_ID;
    private string player_name;
    private int cash;
    private Job job;
    private Dictionary<string, int> income;
    private Dictionary<string, int> expense;
    private Dictionary<string, int> asset;
    private Dictionary<string, int> liabilities;

    public string Id { get => id; set => id = value; }
    public string Player_ID { get => player_ID; set => player_ID = value; }
    public string Player_name { get => player_name; set => player_name = value; }
    public Dictionary<string, int> Income { get => income; set => income = value; }
    public Dictionary<string, int> Expense { get => expense; set => expense = value; }
    public Dictionary<string, int> Asset { get => asset; set => asset = value; }
    public Dictionary<string, int> Liabilities { get => liabilities; set => liabilities = value; }
    public int Cash { get => cash; set => cash = value; }
    public Job Job { get => job; set => job = value; }

    public Financial_Report(string id, string player_ID, string player_name,Job job)
    {
        this.Id = id;
        this.Player_ID = player_ID;
        this.Player_name = player_name;
        this.Cash = job.ListAsset["Cash"];
        this.Job = job;
        this.Income = job.ListIncome;
        this.Expense = job.ListExpense;
        this.Asset = job.ListAsset;
        this.Liabilities = job.ListLiabilities;
    }

}
