
using UnityEngine;

public class MarshmallowAll : MonoBehaviour
{
    public float rotationSpeed =1f;

    [SerializeField] float healamount = 5f;
    PlayerManager Player;
   


    private void Start()
    {

        Player = FindObjectOfType<PlayerManager>();


    }
    private void Update()
    {
        transform.Rotate(0,rotationSpeed, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().PlaySound("MarshmallowSound");

        
         Player.playerHealth += healamount;
         Destroy(gameObject);


















    }

}
