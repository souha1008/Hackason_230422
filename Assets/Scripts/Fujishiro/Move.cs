using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    [SerializeField] float destroyTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x -= speed;
        transform.position = pos;
    }
}
