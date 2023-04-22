using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLazer : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    [SerializeField] private Sprite HardSprite;

    public GameObject score;
    public GameObject LifeManager;


    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        score = GameObject.Find("Score");
        LifeManager = GameObject.Find("LifeManager");
            
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Soft")
        {
            var spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

            spriteRenderer.sprite = HardSprite;

            score.GetComponent<ObjCheck>().AddScore(10);

        }

        if (collision.gameObject.tag == "Hard")
        {
            Destroy(collision.gameObject);
            LifeManager.GetComponent<LifeManager>().AddLife(-1);
        }
    }
}
