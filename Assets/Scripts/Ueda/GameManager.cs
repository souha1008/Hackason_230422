using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Fade fade;
    public bool isPlayable;
    public bool isFade;
    private ScoreManager scoreManager;
    [SerializeField]private GameObject Scoreobj;
    // Start is called before the first frame update
    void Start()
    {
        fade.StartFade(true);
        isPlayable = false;
        isFade = false;
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isFade)
        {
            fade.StartFade(false);
        }
        if(isPlayable)  // ゲーム本体のルールを書いてよい
        {
            if (fade.isEnd)
            {
                // ここでリザルトにスコアを持っていく処理
                scoreManager.Score = Scoreobj.GetComponent<ObjCheck>().Score;
                //========================================

                SceneManager.LoadScene("ResultScene");
            }
        }
        else
        {
            if (fade.isEnd)
            {
                isPlayable = true;
                fade.isEnd = false;
            }
        }
    }

    void SendScore(Scene next,LoadSceneMode mode)
    {

    }
}
