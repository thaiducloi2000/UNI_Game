public class DownSize : Action
{

    public DownSize(float cost, string description)
    {
        this.type = Action.ActionType.DownSize;
        this.cost = cost;
        this.name = "Down Size";
        this.description = description;
    }

    public override void doAction()
    {
        base.doAction();
    }
}
