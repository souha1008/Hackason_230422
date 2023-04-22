using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThrough : MonoBehaviour
{

    private BoxCollider2D boxCollider2D;
    public GameObject LifeManager;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        LifeManager = GameObject.Find("LifeManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Soft" || collision.gameObject.tag == "Hard")
        {
            LifeManager.GetComponent<LifeManager>().AddLife(-1);

        }

    }
}
