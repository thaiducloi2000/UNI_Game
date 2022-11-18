using TMPro;
using UnityEngine;

public class Deal : MonoBehaviour
{
    public GameObject parent;
    public GameObject title;
    public GameObject Description;
    public GameObject Cost;
    public GameObject mortgage_dividend;
    public GameObject cashflow_TradingRange;
    public GameObject downpay_sharesOwned;



    public void setTextDeal(string title,string description,string cost,string mortgage_dividend,string cashflow_TradingRange,string downpay_sharesOwned)
    {
        TextMeshProUGUI titleText = this.title.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI descriptionText = this.Description.GetComponent<TextMeshProUGUI>();
        //TextMeshProUGUI costText = this.Cost.GetComponent<TextMeshProUGUI>();
        //TextMeshProUGUI mortgage_dividendText = this.mortgage_dividend.GetComponent<TextMeshProUGUI>();
        //TextMeshProUGUI cashflow_TradingRangeText = this.cashflow_TradingRange.GetComponent<TextMeshProUGUI>();
        //TextMeshProUGUI downpay_sharesOwnedText = this.downpay_sharesOwned.GetComponent<TextMeshProUGUI>();
        titleText.SetText(title);
        string des = description + "\nCost: $" + cost + "\nDividend: " + mortgage_dividend + "\nTrading range: " + cashflow_TradingRange + "\nShares owned: " + downpay_sharesOwned; ;
        descriptionText.SetText(des);
        //costText.text = "Cost: $" + cost;
        //mortgage_dividendText.text = "Dividend: " + mortgage_dividend;
        //cashflow_TradingRangeText.text = "Trading range: " + cashflow_TradingRange;
        //downpay_sharesOwnedText.text = "Shares owned: " + downpay_sharesOwned;
    }

    public void setTextDeal(Action action)
    {
        TextMeshProUGUI titleText = this.title.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI descriptionText = this.Description.GetComponent<TextMeshProUGUI>();
        titleText.SetText(action.name);
        string des = action.description + "\nCost: $" + action.cost;
        descriptionText.SetText(des);
    }

    public void ButtonExit()
    {
        this.parent.SetActive(false);
    }

}
