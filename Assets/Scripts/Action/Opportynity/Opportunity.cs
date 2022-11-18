

public class Opportunity : Action
{
    // ------------------ DEFIND       ---------------------------
    // ------------------ BASE PROPERTY---------------------------
    public enum typeDeal { Small,Big};

    private typeDeal type_Deal;
    private string opportunity_name;
    private string description;
    

    public string Description { get => description; set => description = value; }
    public string Opportunity_name { get => opportunity_name; set => opportunity_name = value; }
    public typeDeal Type_Deal { get => type_Deal; set => type_Deal = value; }

}
