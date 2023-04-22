using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public int Life = 5;
    [SerializeField] GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Life <= 0)
        {
            GameManager.GetComponent<GameManager>().isFade = true;
        }
        if (Input.GetKeyDown(KeyCode.L)) Life--;
    }

    public void AddLife(int add)
    {
        Life -= add;
    }
}
