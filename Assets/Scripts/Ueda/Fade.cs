using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade : MonoBehaviour
{
    public float fadeTime;
    [SerializeField] Image image;
    public Color color;
    public float loopCount;
    public bool isEnd;
    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeIn()
    {
        // ウェイト時間算出
        float waitTime = fadeTime / loopCount;

        // 色の間隔を算出
        float interval = 255.0f / loopCount;

        // 色を徐々に変えるループ
        for (float alpha = 0.0f; alpha > 0.0f; alpha -= interval)
        {
            // 待ち時間
            yield return new WaitForSeconds(waitTime);

            // Alpha値を少しずつ下げる
            Color new_color = image.color;
            new_color.a = alpha / 255.0f;
            image.color = new_color;
        }
    }

    IEnumerator FadeOut()
    {
        // ウェイト時間算出
        float waitTime = fadeTime / loopCount;

        // 色の間隔を算出
        float interval = 255.0f / loopCount;

        // 色を徐々に変えるループ
        for (float alpha = 0.0f; alpha <= 255.0f; alpha += interval)
        {
            // 待ち時間
            yield return new WaitForSeconds(waitTime);

            // Alpha値を少しずつ上げる
            Color new_color = image.color;
            new_color.a = alpha / 255.0f;
            image.color = new_color;
        }
        isEnd = true;
    }

    public void StartFade(bool b)// trueでIn falseでOut
    {
        if(b)
        {
            StartCoroutine("FadeIn");
        }
        else
        {
            StartCoroutine("FadeOut");
        }
    }
}
