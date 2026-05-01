using UnityEngine;
using TMPro;
using Unity.Mathematics; // Required for TextMeshPro

public class EndScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "TOTAL MONEY COLLECTED: " + UpdateTimeMoney.totalMoneyCollected.ToString();
    }

}
