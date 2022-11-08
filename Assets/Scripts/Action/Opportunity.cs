
public class Opportunity : Action
{
    // ------------------ DEFIND       ---------------------------
    // ------------------ BASE PROPERTY---------------------------
    public enum typeDeal { NULL,Small,Big};

    private typeDeal type = typeDeal.NULL;
    private string opportunity_name;
    private string description;

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
    //public float Cost { get => cost; set => cost = value; }
    public float Mortgage { get => mortgage; set => mortgage = value; }
    public float Cashflow { get => cashflow; set => cashflow = value; }
    public float Downpay { get => downpay; set => downpay = value; }
    public float Dividend { get => dividend; set => dividend = value; }
    public float MaxTradingRange { get => maxTradingRange; set => maxTradingRange = value; }
    public float MinTradingRange { get => minTradingRange; set => minTradingRange = value; }
    public float SharesOwned { get => sharesOwned; set => sharesOwned = value; }
    public string Description { get => description; set => description = value; }
    public string Opportunity_name { get => opportunity_name; set => opportunity_name = value; }


    // ----------------------------------- Create New BIG DEAL------------------------------------- 
    public Opportunity(typeDeal type,string opportunity_name, string description, float cost, float mortgage, float cashflow, float downpay)
    {
        base.type = ActionType.Opportunity;
        this.Type = type;
        this.opportunity_name = opportunity_name;
        base.cost = cost;
        this.Mortgage = mortgage;
        this.Cashflow = cashflow;
        this.Downpay = downpay;
        this.Description = description;
    }
    // ----------------------------------- Create New SMALL DEAL------------------------------------- 
    public Opportunity(typeDeal type, string opportunity_name, string description, float cost, float dividend, float maxTradingRange, float minTradingRange, float sharesOwned)
    {
        base.type = ActionType.Opportunity;
        this.Type = type;
        this.opportunity_name = opportunity_name;
        base.cost = cost;
        this.Dividend = dividend;
        this.MaxTradingRange = maxTradingRange;
        this.MinTradingRange = minTradingRange;
        this.SharesOwned = sharesOwned;
        this.Description = description;
    }
}
