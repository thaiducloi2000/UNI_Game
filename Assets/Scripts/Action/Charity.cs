
public class Charity : Action
{
    public Charity(float cost,string name, string description)
    {
        this.type = Action.ActionType.Charity;
        this.cost = cost;
        this.description = description;
        this.name = name;
    }


    public override void doAction()
    {
        base.doAction();
    }
}
