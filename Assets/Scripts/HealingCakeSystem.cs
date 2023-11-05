using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingCakeSystem : MonoBehaviour
{
    public float rotationSpeed =1;

    [SerializeField] float healamount = 5f;
    PlayerManager Player;


    private void Start()
    {

        Player = FindObjectOfType<PlayerManager>();

    }
    private void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().PlaySound("CupcakeSound");

        Player.playerHealth += healamount; 




        Destroy(gameObject);
    }

}
