using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Text scoreKey;
    public int keyScore = 0;


    void Update()
    {
        scoreKey.text = "Keys " + keyScore;
    } 




}
