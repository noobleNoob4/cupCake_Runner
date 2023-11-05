using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public  float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerManager Player;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerManager>();

    }

    private void Update()
    {
        
        //CurrentHealth = Player.playerHealth;
        healthBar.fillAmount = CurrentHealth / MaxHealth;
        
       
        
    }
    


}
