using UnityEngine.SceneManagement;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
   public void PlayAgain()
    {
        SceneManager.LoadScene("RainBow");


    }
    public void Quit()
    {
        Application.Quit();
    }
    public void NewGameStart()
    {
        SceneManager.LoadScene("Rainbow");
        
    }
    public void NewCharacters()
    {
        SceneManager.LoadScene("CharacterMenu");
    }
    public void PlayToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void SettingsMenu()
    {
        SceneManager.LoadScene("Settings");
    }
}
