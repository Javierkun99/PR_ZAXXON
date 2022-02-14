using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clasificacion : MonoBehaviour
{
    public float score;
    [SerializeField] Text scoreText;

    private void Update()
    {
        score += 1 * Time.deltaTime;
        scoreText.text = "Score:" + Mathf.Round(score);
    }

}
