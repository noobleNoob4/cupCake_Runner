using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public int currentPlayerIndex = 0;
    //Arrays
    public GameObject[] playerS;
    void Start()
    {
        currentPlayerIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);

        foreach (GameObject character in playerS)
            character.SetActive(false);
        playerS[currentPlayerIndex].SetActive(true);


    }
}
