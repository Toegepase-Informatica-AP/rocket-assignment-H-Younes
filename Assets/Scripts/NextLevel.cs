﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string level;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(level);
    }
}
