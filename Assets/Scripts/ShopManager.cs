using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    

    public int currentPlayerIndex = 0;
    //Arrays
    public GameObject[] playerModels;
    public PlayerBlueprint[] playerss;
    public Button buyButton;
    public TextMeshProUGUI coinsText;




    
    void Start()
    {
        foreach(PlayerBlueprint player in playerss)
        {
            if(player.price ==0)
            {
                player.isUnlocked = true;
            }
            else
            {
                player.isUnlocked = PlayerPrefs.GetInt(player.name, 0) == 0 ? false : true; 
            }
        }
        UpdateUI();

        currentPlayerIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);

        foreach (GameObject character in playerModels)
            character.SetActive(false);
        playerModels[currentPlayerIndex].SetActive(true);

        
    }
    private void Update()
    {
        UpdateUI();
       

    }


    public void ChangeNext()
    {
        playerModels[currentPlayerIndex].SetActive(false);
        currentPlayerIndex++;
        if(currentPlayerIndex == playerModels.Length)
        {
            currentPlayerIndex = 0;
        }
        playerModels[currentPlayerIndex].SetActive(true);
        PlayerBlueprint p = playerss[currentPlayerIndex];
        if (!p.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectedCharacter", currentPlayerIndex);
        UpdateUI();


    }
    public void ChangeBack()
    {
        playerModels[currentPlayerIndex].SetActive(false);
        currentPlayerIndex--;
        if (currentPlayerIndex == -1)
        {
            currentPlayerIndex = playerModels.Length -1;
        }
        playerModels[currentPlayerIndex].SetActive(true);
        PlayerBlueprint p = playerss[currentPlayerIndex];
        if (!p.isUnlocked)
            return;
        PlayerPrefs.SetInt("SelectedCharacter", currentPlayerIndex);
        UpdateUI();


    }
    public void UnlocknewPlayer()

    {
        PlayerBlueprint p = playerss[currentPlayerIndex];
        PlayerPrefs.SetInt(p.name, 1);
        PlayerPrefs.SetInt("SelectedCharacter", currentPlayerIndex);
        p.isUnlocked = true;
        PlayerPrefs.SetInt("NumberOfCoins",PlayerPrefs.GetInt("NumberOfCoins",0) -p.price);


    }
    private void UpdateUI()
    {
        coinsText.text = "" + PlayerPrefs.GetInt("NumberOfCoins", 0);
        PlayerBlueprint p = playerss[currentPlayerIndex];
        if(p.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);

        }
        else
        {
            buyButton.gameObject.SetActive(true);
            buyButton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-" + p.price;
            if(p.price <= PlayerPrefs.GetInt("NumberOfCoins",0))
            {
                buyButton.interactable = true;
            }
            else
            {
                buyButton.interactable = false;
            }

        }
    }

}




