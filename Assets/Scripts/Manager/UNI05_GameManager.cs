using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNI05_GameManager : MonoBehaviour
{
    public static UNI05_GameManager instance;
    [SerializeField] public GameObject StartBlock;
    [SerializeField] public List<Transform> Blocks;
    [SerializeField] public GameObject Chessboard;
    [SerializeField] public GameObject Player;


    // List Job;
    [SerializeField] public Job job;

    // All Action below will tranfer to list<>
    public Opportunity small_deal;
    public Opportunity big_deal;
    public Doodads dood;
    public Charity charity;
    public Offer offers;
    public DownSize downsize;
    public Paycheck paycheck;
    public int diceResult = 0;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("There are more  than 1 UNI05_GameManager instance");
            return;
        }
        loadBlock();
        loadJobs();
        LoadAction();
        instance = this;
    }

    private void Start()
    {
        SpawnPlayer();
    }

    public void loadBlock()
    {
        this.Blocks = new List<Transform>();
        for(int i = 0; i < Chessboard.transform.childCount; i++)
        {
            Blocks.Add(Chessboard.transform.GetChild(i).gameObject.transform);
        }
    }


    public void resetDice()
    {
        this.diceResult = 0;
    }

    public void SpawnPlayer()
    {
        Transform startPosition = this.StartBlock.gameObject.transform;
        Vector3 pos = new Vector3(startPosition.position.x, 0.6f, startPosition.position.z);
        this.Player = Instantiate(Player, pos, Quaternion.identity);
        //Player player = new Player("Test", "Test", this.job);
        //this.Player.AddComponent<Player>();
        Player player = this.Player.GetComponent<Player>();
        Financial_Report financial_Report = new Financial_Report("1", "Test", "Test", this.job);
        player._financial_Report = financial_Report;
    }

    public void Move(int numOfDice)
    {
        MoveManagment.instance.Move(Player,numOfDice,Blocks);
    }


    // Load all Action to list, is testing add single Action first
    public void LoadAction()
    {
        //this.opportunities = new List<Opportunity>();
        //Opportunity op = new Opportunity(Opportunity.typeDeal.Small,"Mutual Fund","Lower interest rates drive maket and fund to strong showing.",5,0,30,10,0);
        //opportunities.Add(op);
        Opportunity op = new Small_Deal("Mutual Fund", "Lower interest rates drive maket and fund to strong showing.", 5, 0, 30, 10, 0);
        Opportunity big_op = new Big_Deal("Mutual Fund Big", "Lower interest rates drive maket and fund to strong showing.", 5, 0, 30, 10);
        Doodads doodads = new Doodads(12,"Doodads","Test Doodads");
        Charity chari = new Charity(11, "Charity", "Test Charity");
        Offer off = new Offer(Offer.typeOffer.H1, "2 Br / 2 Ba",10,"Test offer");
        DownSize down = new DownSize(9,"Test DownSize");
        Paycheck pay = new Paycheck(300);


        // loading
        this.small_deal = op;
        this.big_deal = big_op;
        this.dood = doodads;
        this.charity = chari;
        this.offers = off;
        this.downsize = down;
        this.paycheck = pay;
    }

    public void loadJobs()
    {
        Dictionary<string, int> incomes = new Dictionary<string, int>();
        Dictionary<string, int> expense = new Dictionary<string, int>();
        Dictionary<string, int> assets = new Dictionary<string, int>(); 
        Dictionary<string, int> liabilities = new Dictionary<string, int>();
        incomes.Add("salary", 13200);
        expense.Add("Taxes", 3420);
        expense.Add("Home Mortage Payment", 1920);
        expense.Add("Car Loan Payment", 750);
        expense.Add("Credit Card Payment", 380);
        expense.Add("Retail Payment", 270);
        expense.Add("Shopping Expense", 50);
        expense.Add("Other Expense", 2880);
        assets.Add("Cash", 400);
        liabilities.Add("Home Mortage",202000);
        liabilities.Add("University Liabilities", 150000);
        liabilities.Add("Car Loan", 19000);
        liabilities.Add("Credit Card", 9000);
        liabilities.Add("Retail Debl", 1000);
        this.job = new Job("Doctor",incomes,expense,assets,liabilities);
    }
}
