
public class Small_Deal : Opportunity
{
    private float dividend;
    private float maxTradingRange;
    private float minTradingRange;
    private float sharesOwned;


    public float Dividend { get => dividend; set => dividend = value; }
    public float MaxTradingRange { get => maxTradingRange; set => maxTradingRange = value; }
    public float MinTradingRange { get => minTradingRange; set => minTradingRange = value; }
    public float SharesOwned { get => sharesOwned; set => sharesOwned = value; }

    // ----------------------------------- Create New SMALL DEAL------------------------------------- 
    public Small_Deal(string opportunity_name, string description, float cost, float dividend, float maxTradingRange, float minTradingRange, float sharesOwned)
    {
        this.type = Action.ActionType.Opportunity;
        this.Type_Deal = Opportunity.typeDeal.Small;
        this.Opportunity_name = opportunity_name;
        this.cost = cost;
        this.Dividend = dividend;
        this.MaxTradingRange = maxTradingRange;
        this.MinTradingRange = minTradingRange;
        this.SharesOwned = sharesOwned;
        this.Description = description;
    }

    public override void doAction()
    {
        base.doAction();
    }
}
