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

    public int Rank = 0;

    public int totalScore = 0;

    public int combo = 0;


    void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("checking", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checking()
    {
        int rand = 1;
        if (rand == Random.Range(1, 5))
        {
            cheif.cooker.animationStart();
        }
    }

    public void addScore()
    {
        Rank = combo / 10;
        combo += 1;
        totalScore += combo;
        comboText.text = combo.ToString();
        scoreText.text = totalScore.ToString();
        Debug.Log(Rank);
    }
}
