using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public int Score;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ScoreManager");
        if (1 < objs.Length) Destroy(objs[1]);
    }
}
