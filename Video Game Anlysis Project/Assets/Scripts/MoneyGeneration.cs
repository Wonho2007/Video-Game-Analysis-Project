using UnityEngine;

public class MoneyGeneration : MonoBehaviour
{
    public GameObject moneyPrefab;
    public float moneyCollected = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(moneyPrefab, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
