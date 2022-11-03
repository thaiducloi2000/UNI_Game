using UnityEngine;

public class Block : MonoBehaviour
{
    public enum Action { Offer, Opportunity, Liability, Child, Charity, Paycheck, DownSize };
    [Header("Block Detail")]
    [SerializeField] public string ID;
    [SerializeField] public Action action;


    private void Awake()
    {
        Renderer render= this.GetComponent<Renderer>();
        ChangeColor(render);
    }

    private void ChangeColor(Renderer render)
    {
        if(this.action == Action.Offer)
        {
            render.material.color = Color.blue;
        }
        if (this.action == Action.Opportunity)
        {
            render.material.color = Color.green;
        }
        if (this.action == Action.Liability)
        {
            render.material.color = Color.gray;
        }
        if (this.action == Action.Child)
        {
            Color orage = new Color(1.0f, 0.64f, 0.0f);
            render.material.color = orage;
        }
        if (this.action == Action.Charity)
        {
            Color SkyBlue = new Color(0f, 0f, 0.5f,0.5f);
            render.material.color = SkyBlue;
        }
        if (this.action == Action.Paycheck)
        {
            render.material.color = Color.yellow;
        }
        if (this.action == Action.DownSize)
        {
            render.material.color = Color.red;
        }
    }

    public void OnMouseDown()
    {
        Debug.Log(this.action);
    }
}
