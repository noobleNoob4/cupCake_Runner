using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSystem : MonoBehaviour
{
    public GameObject goldText;
    public static int totalGold;


    private void Update()
    {
        goldText.GetComponent<Text>().text = "GOLD:" + totalGold;
    }
}
