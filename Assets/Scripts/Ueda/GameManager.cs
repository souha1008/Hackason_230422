using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Fade fade;
    public bool isPlayable;
    public bool isFade;
    // Start is called before the first frame update
    void Start()
    {
        fade.StartFade(true);
        isPlayable = false;
        isFade = false;
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
            if (Input.GetKeyDown(KeyCode.Return))
            {
                fade.StartFade(false);
            }
            if (fade.isEnd)
            {
                // ここでリザルトにスコアを持っていく処理
                
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
