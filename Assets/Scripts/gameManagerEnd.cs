using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerEnd : MonoBehaviour
{

    public int finalScore = 0;
    public Text finalTest;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = gameManager.I.totalScore;
    }

    // Update is called once per frame
    void Update()
    {
        finalTest.text = finalScore.ToString();
    }
}
