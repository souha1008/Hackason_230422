using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] Fade fade;
    bool isPlayable;
    // Start is called before the first frame update
    void Start()
    {
        isPlayable = false;
        fade.StartFade(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayable)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                fade.StartFade(false);
            }
            if (fade.isEnd)
            {
                SceneManager.LoadScene("GameScene");
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
}
