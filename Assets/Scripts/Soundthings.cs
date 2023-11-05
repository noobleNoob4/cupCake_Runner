using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Soundthings : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
    }

}
