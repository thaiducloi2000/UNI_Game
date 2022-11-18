public class Paycheck : Action
{
    public Paycheck(float cost)
    {
        this.type = Action.ActionType.Paycheck;
        this.cost = cost;
        this.name = "Paycheck";
        this.description = " Get Amount Salary of month";
    }

    public override void doAction()
    {
        base.doAction();
    }
}
