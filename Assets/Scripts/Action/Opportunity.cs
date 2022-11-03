using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opportunity : MonoBehaviour
{
    // Start is called before the first frame update
    private string opportunity_name;
    public enum typeDeal { NULL,Small,Big};

    private typeDeal type = typeDeal.NULL;
    private float cost;

    // ------------------ BIG DEAL---------------------------
    private float mortgage;
    private float cashflow;
    private float downpay;
    // ------------------ SMALL DEAL ------------------------
    private float dividend;
    private float maxTradingRange;
    private float minTradingRange;
    private float sharesOwned;

    public typeDeal Type { get => type; set => type = value; }
    public float Cost { get => cost; set => cost = value; }
    public float Mortgage { get => mortgage; set => mortgage = value; }
    public float Cashflow { get => cashflow; set => cashflow = value; }
    public float Downpay { get => downpay; set => downpay = value; }
    public float Dividend { get => dividend; set => dividend = value; }
    public float MaxTradingRange { get => maxTradingRange; set => maxTradingRange = value; }
    public float MinTradingRange { get => minTradingRange; set => minTradingRange = value; }
    public float SharesOwned { get => sharesOwned; set => sharesOwned = value; }


    // ----------------------------------- Create New BIG DEAL------------------------------------- 
    public Opportunity(typeDeal type, float cost, float mortgage, float cashflow, float downpay)
    {
        this.Type = type;
        this.Cost = cost;
        this.Mortgage = mortgage;
        this.Cashflow = cashflow;
        this.Downpay = downpay;
    }
    // ----------------------------------- Create New SMALL DEAL------------------------------------- 
    public Opportunity(typeDeal type, float cost, float dividend, float maxTradingRange, float minTradingRange, float sharesOwned)
    {
        this.Type = type;
        this.Cost = cost;
        this.Dividend = dividend;
        this.MaxTradingRange = maxTradingRange;
        this.MinTradingRange = minTradingRange;
        this.SharesOwned = sharesOwned;
    }
}
