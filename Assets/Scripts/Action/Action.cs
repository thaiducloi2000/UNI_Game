

public class Action
{

    public enum ActionType { Offer, Opportunity, Doodads, Charity, Paycheck, DownSize }
    public ActionType type { get; set; }
    public float cost { get; set; }

    public string name { get; set; }
    public string description { get; set; }


    public virtual void doAction()
    {

    } 

}
