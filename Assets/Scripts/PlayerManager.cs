using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float zSpeed = 5;

    //ALLJump...
    public float jumpForce;
    public float gravityC = -20;

    HealthBar playerCurrenHealth;

    

    
   



    public Transform groundCheck;
    public LayerMask groundLayer;
    public Animator animator;
    private CharacterController controller;
    private Vector3 direction;
   
    
    public bool isDead;
      
    public float maksZspeed = 20f;
    public  float playerHealth = 100f;
    

    private int mainLane = 1;  // 0 sol 1 orta 2 sað
    public float laneDistance = 4;

  

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerCurrenHealth = FindObjectOfType<HealthBar>();



    }


    void Update()
    {
        playerCurrenHealth.CurrentHealth = playerHealth;
        decreaseHealth();
        GameOverDie();
        direction.y += gravityC * Time.deltaTime;
        if (controller.isGrounded)
        {


            if (SwipeManager.swipeUp)   //SwipeManager.swipeUp

            {
                Jump();
            }
        }












        if (playerHealth > 100)
        {
            playerHealth = 100;
        }
       
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.3f, groundLayer);
        animator.SetBool("isGrounded",isGrounded);


        


            if (zSpeed < maksZspeed)
        {
            zSpeed += 0.2f * Time.deltaTime;


        }
        
        direction.z = zSpeed;
       
      
        

        if (SwipeManager.swipeRight)
        {
            mainLane++;
            if(mainLane == 3)
            {
                mainLane = 2;
            }
        }
        if (SwipeManager.swipeLeft)
        {
            mainLane--;
            if (mainLane == -1)
            {
                mainLane = 0;
            }
        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up; //This is actually the y and z coordinates of the player then we set the x position that depends on the desiredLane (middle, right or left)


        if (mainLane ==0 )
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if(mainLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.sqrMagnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        }
        
        controller.Move(direction * Time.deltaTime);
























    }



    private void decreaseHealth()
    {
        playerHealth -= 10 * Time.deltaTime;
        

    }
    private void GameOverDie()
    {

        if (playerHealth <= 0)
        {
            isDead = true;
            zSpeed = 0;
            GameandLevelManager.gameOver = true;
            animator.SetTrigger("Dead");
            direction.y =0;
            mainLane = 1;  
          












}
    }
    private void Jump()
    {
        direction.y = jumpForce;

    }







}
