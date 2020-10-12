using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public Text scoretxt;

    void Start()
    {
        
    }

    void Update()
    {
        scoretxt.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score += 1;
        }else if (other.CompareTag("Enemy")){
            score -= 1;
        }
    }
}
