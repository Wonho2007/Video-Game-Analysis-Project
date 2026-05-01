using UnityEngine;
using TMPro;
using Unity.Mathematics; // Required for TextMeshPro
using UnityEngine.SceneManagement;

public class UpdateTimeMoney : MonoBehaviour
{
    public AudioSource audioSource;
    public int numberGoalsCompleted = 0;
    public float timeRemaining = 59; // Time in seconds
    public int moneyNeeded = 5;
    public static int totalMoneyCollected = 0;
    public TextMeshProUGUI timeText; 
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI totalMoneyText;
    public bool timerIsRunning = false;

    private void Start()
    {
        timerIsRunning = true;
        DisplayMoney();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime();
            }
            else
            {
                SceneManager.LoadScene("End");
            }
        }
    }

    void DisplayTime()
    {
        float timeInt = math.floor(timeRemaining);
        timeText.text = "" + timeInt;
    }

    void DisplayMoney()
    {
        moneyText.text = "Money Needed: " + moneyNeeded;
        totalMoneyText.text = "Total Money Collected: " + totalMoneyCollected;
    }
    public void MoneyWasCollected()
    {
        moneyNeeded--;
        totalMoneyCollected++;

        if(moneyNeeded > 0)
        {
            DisplayMoney();
        }
        else
        {
            numberGoalsCompleted++;
            goalCompleted();
        }
        
    }

    public void goalCompleted()
    {
        //Play sound effect
        audioSource.Stop();
        audioSource.Play();
        moneyNeeded = 5 + 2 * numberGoalsCompleted;
        timeRemaining = 60 - 7 * numberGoalsCompleted;
        if(timeRemaining < 1)
        {
            timeRemaining = 3;
        }
        timerIsRunning = true;
        DisplayMoney();
    }


}
