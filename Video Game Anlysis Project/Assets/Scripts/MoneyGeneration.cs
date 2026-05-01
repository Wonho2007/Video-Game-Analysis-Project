using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class MoneyGeneration : MonoBehaviour
{
    public GameObject moneyPrefab;
    private int pastSpawn = 1;
    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public Transform spawnPointThree;
    public Transform spawnPointFour;
    public Transform spawnPointFive;
    public Transform spawnPointSix;
    public Transform spawnPointSvn;
    public Transform spawnPointEght;
    public Transform spawnPointNine;

    public float moneyCollected = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnMoney();
    }

    // Update is called once per frame
    public void spawnMoney()
    {
        Vector3 moneySpawn = spawnPointOne.position;
        int randomNum = UnityEngine.Random.Range(1, 9);
        while(randomNum == pastSpawn)
        {
            randomNum = UnityEngine.Random.Range(1, 9);
        }
        pastSpawn = randomNum;
        switch (randomNum)
        {
            case 1:
                moneySpawn = spawnPointOne.position;
                break;
            case 2:
                moneySpawn = spawnPointTwo.position;
                break;
            case 3:
                moneySpawn = spawnPointThree.position;
                break;
            case 4:
                moneySpawn = spawnPointFour.position;
                break;
            case 5:
                moneySpawn = spawnPointFive.position;
                break;
            case 6:
                moneySpawn = spawnPointSix.position;
                break;
            case 7:
                moneySpawn = spawnPointSvn.position;
                break;
            case 8:
                moneySpawn = spawnPointEght.position;
                break;
            case 9:
                moneySpawn = spawnPointNine.position;
                break;
        }
        Instantiate(moneyPrefab, moneySpawn, Quaternion.identity);
    }
}
