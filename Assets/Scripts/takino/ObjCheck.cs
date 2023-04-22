using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ObjCheck : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public int Score;
    [SerializeField] private int HardScore;
    [SerializeField] private int SoftScore;
    [SerializeField] private int LostScore;
    [SerializeField] private int MissScore;
    private HiScore hiScore;
    private string FilePath = "./Assets/ScoreTexts.txt";
    private StreamWriter sw;
    private StreamReader sr;
    void Start()
    {
        hiScore = GetComponent<HiScore>();
        if (!File.Exists(FilePath))
        {
            using(File.Create(FilePath))
            {

            }
        }
        else
        {
            sr = new StreamReader(FilePath);
            for (int i = 0; i < hiScore.Score.Length; i++)
            {
                hiScore.Score[i] = int.Parse(sr.ReadLine());
                
            }
            sr.Close();
        }

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Return))
        {
            HiScoreUpdate(Score);
            Writetext();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hard")
        {
            Score += HardScore;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Soft")
        {
            Score += SoftScore;
            Destroy(collision.gameObject);
        }
    }

    private void Writetext()
    {
        sw = new StreamWriter(FilePath);
        for(int i = 0;i < hiScore.Score.Length;i++)
        {
            sw.WriteLine(hiScore.Score[i]);
        }
        sw.Flush();
        sw.Close();
    }

    private void HiScoreUpdate(int score)
    {
        

        for(int i = 0; i < hiScore.Score.Length;i++)
        {
            if(hiScore.Score[i] < score)
            {
                for(int p = hiScore.Score.Length - 2;p >= i; p--)
                {
                    hiScore.Score[p + 1] = hiScore.Score[p];
                }
                hiScore.Score[i] = score;
                break;
            }
        }
    }

}
