using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TMP_Text timerText;

    float tiempo;

    public bool gameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (!gameOver)
        {
            tiempo += Time.deltaTime;

            timerText.text = tiempo.ToString("F2");
        }
    }
}