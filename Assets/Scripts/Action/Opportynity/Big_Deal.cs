
public class Big_Deal : Opportunity
{
    private float mortgage;
    private float cashflow;
    private float downpay;

    public float Mortgage { get => mortgage; set => mortgage = value; }
    public float Cashflow { get => cashflow; set => cashflow = value; }
    public float Downpay { get => downpay; set => downpay = value; }


    // -----------------------------------------Contructor-------------------------------------------
    public Big_Deal(string opportunity_name, string description, float cost, float mortgage, float cashflow, float downpay)
    {
        this.type = Action.ActionType.Opportunity;
        this.Type_Deal = Opportunity.typeDeal.Big;
        this.Opportunity_name = opportunity_name;
        this.cost = cost;
        this.Mortgage = mortgage;
        this.Cashflow = cashflow;
        this.Downpay = downpay;
        this.Description = description;
    }

    public override void doAction()
    {
        base.doAction();
    }
}
