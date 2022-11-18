using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Job : MonoBehaviour
{
    private string job_name;
    [SerializeField] private Dictionary<string, int> listIncome;
    [SerializeField] private Dictionary<string, int> listExpense;
    [SerializeField] private Dictionary<string, int> listAsset;
    [SerializeField] private Dictionary<string, int> listLiabilities;

    public Job(string job_name, Dictionary<string, int> listIncome, Dictionary<string, int> listExpense, Dictionary<string, int> listAsset, Dictionary<string, int> listLiabilities)
    {
        this.job_name = job_name;
        this.listIncome = listIncome;
        this.listExpense = listExpense;
        this.listAsset = listAsset;
        this.listLiabilities = listLiabilities;
    }

    public string Job_name { get => job_name; set => job_name = value; }
    public Dictionary<string, int> ListIncome { get => listIncome; set => listIncome = value; }
    public Dictionary<string, int> ListExpense { get => listExpense; set => listExpense = value; }
    public Dictionary<string, int> ListAsset { get => listAsset; set => listAsset = value; }
    public Dictionary<string, int> ListLiabilities { get => listLiabilities; set => listLiabilities = value; }
}
