using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLazer : MonoBehaviour
{
    public GameObject HardLazer;
    public GameObject SoftLazer;
    [SerializeField] float HiddenTime;

    void Start()
    {
        SoftLazer.SetActive(false);
        HardLazer.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HardLazer.SetActive(true);
            Debug.Log("Hard");
            Invoke("HardLazerNotActive", HiddenTime);
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            SoftLazer.SetActive(true);
            Debug.Log("Soft");
            Invoke("SoftLazerNotActive", HiddenTime);

        }

    }

    void HardLazerNotActive()
    {
        HardLazer.SetActive(false);

    }

    void SoftLazerNotActive()
    {
        SoftLazer.SetActive(false);

    }
}