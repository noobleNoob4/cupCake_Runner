
using UnityEngine;
using UnityEngine.UI;

public class RunScoreScript : MonoBehaviour
{
    public Text runScoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    PlayerManager ifplayerhealth;
    

    public Text highScoretext;
    
   
    

    private void Start()
    {
        ifplayerhealth = FindObjectOfType<PlayerManager>();
        scoreAmount = 0f;
        pointIncreasedPerSecond = 5f;
        highScoretext.text = PlayerPrefs.GetFloat("HighScore").ToString();

    }

    private void Update()
    {


        //if (ifplayerhealth.playerHealth >0)
        //{
        //    runScoreText.text = "Score:" + scoreAmount.ToString();
        //    scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
            

        //}
        if (scoreAmount > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", scoreAmount);
        }












    }
    
}
