using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelManager;
    public float multiplier;
    public Rigidbody self;
    public Transform pos;

    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        pos.position = new Vector3(Random.Range(-8.0f, 8.0f), 10, Random.Range(-4.0f, 4.0f));
        self.AddForce(Random.Range(-2.0f, 2.0f) * multiplier, Random.Range(-10.0f, -2.0f) * multiplier, Random.Range(-2.0f, 2.0f) * multiplier);
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            levelManager.GetComponent<GameManager>().increaseScore();
            spawn();
        }
        
    }
}
