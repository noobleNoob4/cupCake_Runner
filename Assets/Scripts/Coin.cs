using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed =1;

    
    void Update()
    {
        transform.Rotate(0, rotationSpeed,0,Space.World);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().PlaySound("GoldPickUp");
            GameandLevelManager.numberOfCoins += 1;
           PlayerPrefs.SetInt("NumberOfCoins",GameandLevelManager.numberOfCoins);
            Destroy(gameObject);
        }
    }

}
