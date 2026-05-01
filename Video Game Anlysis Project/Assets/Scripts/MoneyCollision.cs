using System;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyCollision : MonoBehaviour
{
    public MoneyGeneration moneyGeneration;
    public UpdateTimeMoney updateTimeMoney;
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moneyGeneration = UnityEngine.Object.FindFirstObjectByType<MoneyGeneration>();
        updateTimeMoney = UnityEngine.Object.FindFirstObjectByType<UpdateTimeMoney>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Play sound effect
            Camera.main.GetComponent<AudioSource>().PlayOneShot(audioSource.clip);

            moneyGeneration.moneyCollected++;
            updateTimeMoney.MoneyWasCollected();
            moneyGeneration.spawnMoney();
            
            Destroy(gameObject);
        }
    }
}
