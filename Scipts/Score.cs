using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private float timestart;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = timestart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timestart += Time.deltaTime;
        ScoreText.text = timestart.ToString("F2");
    }

}
