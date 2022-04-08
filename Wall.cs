using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform self;
    public float onOff;
    void Start()
    {
        //onOff = (onOff + (int)Random.Range(0.5f, 1.5f)) % 2;
        updatePos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updatePos()
    {
        self.position = new Vector3(self.position.x, -9.5f + (onOff * 10), self.position.z);
    }
    
    void toggle()
    {
        onOff = (onOff + 1) % 2;

        updatePos();
    }
}
