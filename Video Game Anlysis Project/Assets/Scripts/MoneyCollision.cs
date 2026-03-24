using System;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyCollision : MonoBehaviour
{
    public MoneyGeneration moneyGeneration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moneyGeneration = UnityEngine.Object.FindFirstObjectByType<MoneyGeneration>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moneyGeneration.moneyCollected++;
            Destroy(gameObject);
        }
    }
}
