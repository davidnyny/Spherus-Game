﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Alex Huang

public class ResolutionNormalization : MonoBehaviour
{
    RectTransform button;

    void Start()
    {
        button = GetComponent<RectTransform>();
        float newDistanceX = 0.65f * ((float)Screen.width / 2f);
        float newDistanceY = 0.26f * ((float)Screen.height / 2f);
        button.anchoredPosition = new Vector3(-newDistanceX, newDistanceY, 0f);
    }
}