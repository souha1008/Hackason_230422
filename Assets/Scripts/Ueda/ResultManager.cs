using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Fade fade;
    bool isPlayable;
    // Start is called before the first frame update
    void Start()
    {
        fade.StartFade(true);
        isPlayable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayable)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                fade.StartFade(false);
            }
            if (fade.isEnd)
            {
                // ここでスコアの送信処理

                //=======================

                SceneManager.LoadScene("TitleScene");
            }
        }
        else
        {
            if(fade.isEnd)
            {
                isPlayable = true;
                fade.isEnd = false;
            }
        }
    }
}
