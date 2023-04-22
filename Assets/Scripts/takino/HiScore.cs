using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int num;
    [HideInInspector] public int[] Score = new int[10];
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
