using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public int Life = 5;
    [SerializeField] GameObject GameManager;
    [SerializeField] GameObject[] peke;

    public int miss = 0;
    // Start is called before the first frame update
    void Start()
    {
        miss = 0;
        Life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life <= 0)
        {
            GameManager.GetComponent<GameManager>().isFade = true;
        }
        if (Input.GetKeyDown(KeyCode.L)) AddLife(-1);
    }

    public void AddLife(int add)
    {
        Life += add;
        peke[miss].SetActive(true);
        miss++;
    }
}
