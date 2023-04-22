using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftLazer : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    [SerializeField] private Sprite SoftSprite;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hard")
        {
            var spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

            spriteRenderer.sprite = SoftSprite;


        }

        if (collision.gameObject.tag == "Soft")
        {
            Destroy(collision.gameObject);


        }

    }
}
