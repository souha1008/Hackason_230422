using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    [SerializeField] float destroyTime = 5.0f;
    [SerializeField] GameObject spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        speed = (float)spawnManager.GetComponent<SpawnManager>().bpm / 20000;
        var pos = transform.position;
        pos.x -= speed;
        transform.position = pos;
    }
}
