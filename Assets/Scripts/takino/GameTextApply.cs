using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextApply : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text scoretext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scoretext.text = "Score :" + GetComponent<ObjCheck>().Score.ToString();
    }
}
