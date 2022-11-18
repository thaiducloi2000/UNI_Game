using UnityEngine;

public class Player : MonoBehaviour
{
    public string player_Id;
    public string player_Name;
    public Transform position;
    public Financial_Report _financial_Report;

    private void Start()
    {
        position = this.GetComponent<Transform>();
        Debug.Log(_financial_Report.Cash);
        Debug.Log(_financial_Report.Liabilities["Home Mortage"]);
    }
    
}
