using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextApply : MonoBehaviour
{
    private ScoreManager scoreManager;
    [SerializeField] private Text scoretext;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

       score = scoreManager.Score;

        scoretext.text = "SCORE :" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
