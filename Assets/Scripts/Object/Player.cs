using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform position;

    private void Start()
    {
        position = this.GetComponent<Transform>();
    }
    private void Update()
    {
        
    }
}
