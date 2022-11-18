public class Doodads : Action
{

    public Doodads(float cost,string name, string description)
    {
        this.type = ActionType.Doodads;
        this.cost = cost;
        this.name = name;
        this.description = description;
    }

    public override void doAction()
    {
        base.doAction();
    }
}
