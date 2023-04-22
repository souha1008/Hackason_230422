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
    public bool isFading;
    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;
        isFading = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeIn()
    {
        // �E�F�C�g���ԎZ�o
        float waitTime = fadeTime / loopCount;

        // �F�̊Ԋu���Z�o
        float interval = 255.0f / loopCount;

        // �F�����X�ɕς��郋�[�v
        for (float alpha = 255.0f; alpha > 0.0f; alpha -= interval)
        {
            // �҂�����
            yield return new WaitForSeconds(waitTime);

            // Alpha�l��������������
            Color new_color = image.color;
            new_color.a = alpha / 255.0f;
            image.color = new_color;
        }
        isEnd = true;
        isFading = false;
    }

    IEnumerator FadeOut()
    {
        // �E�F�C�g���ԎZ�o
        float waitTime = fadeTime / loopCount;

        // �F�̊Ԋu���Z�o
        float interval = 255.0f / loopCount;

        // �F�����X�ɕς��郋�[�v
        for (float alpha = 0.0f; alpha <= 255.0f; alpha += interval)
        {
            // �҂�����
            yield return new WaitForSeconds(waitTime);

            // Alpha�l���������グ��
            Color new_color = image.color;
            new_color.a = alpha / 255.0f;
            image.color = new_color;
        }
        isEnd = true;
        isFading = false;
    }

    public void StartFade(bool b)// true��In false��Out
    {
        if(!isFading)
        {
            if (b)
            {
                StartCoroutine("FadeIn");
                Debug.Log("FadeInStart");
                isFading = true;
            }
            else
            {
                StartCoroutine("FadeOut");
                isFading = true;
            }
        }
    }
}
