using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject soft;
    [SerializeField] GameObject hard;
    [SerializeField] GameObject yasumi;

    public int bpm = 100;
    public float nowTime;
    public float spawn_interval = 0f;
    public int kosuu = 0;


    // Start is called before the first frame update
    void Start()
    {
        SpawnInterval_Clac();
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if (nowTime >= spawn_interval)
        {
            kosuu += 1;

            if (kosuu != 4)
            {
                if (kosuu != 8)
                {
                    if (kosuu != 16)
                    {
                        int rm = Random.Range(0, 50);
                        if (rm % 2 == 0) // ƒ\ƒtƒg
                        {
                            Instantiate(soft, this.transform);
                        }
                        else
                        {
                            Instantiate(hard, this.transform);
                        }
                    }
                    else
                    {
                        //Instantiate(yasumi, this.transform);
                    }
                }
                else
                {
                    //Instantiate(yasumi, this.transform);
                }
            }
            else
            {
                //Instantiate(yasumi, this.transform);
            }
            nowTime = 0;
        }
        if(kosuu >= 16)
        {
            kosuu = 0;
            nowTime = 0;
        }
    }

    public void SpawnInterval_Clac()
    {
        spawn_interval = 60000 / (float)bpm;
        spawn_interval /= 1000;
    }
}
