using System;
using UnityEngine;

public class Action : MonoBehaviour
{

    public enum ActionType { Offer, Opportunity, Liability, Child, Charity, Paycheck, DownSize }
    public ActionType type { get; set; }
    public float cost { get; set; } 

}
