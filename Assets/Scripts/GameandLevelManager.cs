using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameandLevelManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverObject;
    public static int numberOfCoins;
    public Text coinsText;
    TileManagerFix tileManagerFix;
     void Start()
    {
        

        gameOver = false;
        Time.timeScale = 1;
        tileManagerFix = FindObjectOfType<TileManagerFix>();





    }
    private void Awake()
    {

        
       numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);


    }

    private void Update()
    {
        if(numberOfCoins == 2147483645)
        {
            numberOfCoins = 2000000000;
        }
        if(gameOver)
        {
            //Time.timeScale = 0;
             
             gameOverObject.SetActive(true);
            tileManagerFix.enabled = false;

             
            



        }
        coinsText.text = "" + numberOfCoins;
    }
  
    
}
