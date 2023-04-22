using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextApply : MonoBehaviour
{
    private ScoreManager scoreManager;
    [SerializeField] private Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        scoretext.text = "SCORE :" + scoreManager.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
