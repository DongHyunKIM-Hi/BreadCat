using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static gameManager I;

    public Text scoreText;

    public Text comboText;

    public int totalScore = 0;

    public int combo = 0;


    void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("checking", 0, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checking()
    {
        cheif.cooker.animationStart();
    }

    public void addScore()
    {
        combo += 1;
        totalScore += combo;
        comboText.text = combo.ToString();
        scoreText.text = totalScore.ToString();
    }
}
