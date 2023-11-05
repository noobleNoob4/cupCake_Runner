using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleReaction : MonoBehaviour
{
    [SerializeField] float damage = 10;
    PlayerManager Player;
    public ParticleSystem cloudDestroyParticleEf;

    private void Start()
    {
        Player = FindObjectOfType<PlayerManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().PlaySound("CloudSound");

        Instantiate(cloudDestroyParticleEf, transform.position, Quaternion.identity);

        Player.playerHealth -= damage;

        Destroy(gameObject);
    }


}
