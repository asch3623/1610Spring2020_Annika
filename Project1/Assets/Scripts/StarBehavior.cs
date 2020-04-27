﻿using DataTypes;
using UnityEngine;
using UnityEngine.UI;

public class StarBehavior : MonoBehaviour
{
    private Text starText;
    public IntData starCount;

    void Start()
    {
        starText = GetComponent<Text>();
    }
    void Update()
    {
        starText.text = "Stars: " + starCount.value.ToString() + "/4";
        if (starCount.value == 4)
        {
            starText.text = "Now Head Back!";
        }
    }
}
