
public class Offer : Action
{

    // Change = sell or buy house , H1 = buyer need to buy 2 Br / 2 Ba, H2 = buyer need to buy hose 3 Br /2 Ba
    public enum typeOffer { Chance, H1, H2 }

    private typeOffer _typeOffer;

    public typeOffer TypeOffer { get => _typeOffer; set => _typeOffer = value; }

    public Offer(typeOffer typeOffer, string offerName,float cost,string description)
    {
        this.type = ActionType.Offer;
        this.cost = cost;
        this.TypeOffer = typeOffer;
        this.name = offerName;
        this.description = description;
    }

    public override void doAction()
    {
        base.doAction();
    }
}
