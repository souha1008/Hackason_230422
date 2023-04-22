using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLazer : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    [SerializeField] private Sprite HardSprite;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Active");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Soft")
        {
            var spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

            spriteRenderer.sprite = HardSprite;

            Debug.Log("Hit");
        }

        if (collision.gameObject.tag == "Hard")
        {
            Destroy(collision.gameObject);
        }
    }
}
