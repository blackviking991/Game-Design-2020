using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMotion : MonoBehaviour
{
    public int speed = 3;
    float initialpos;
    // Start is called before the first frame update
    void Start()
    {
        initialpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= initialpos - 6)
        {
            speed = 3;
        }
        if (transform.position.x >= initialpos + 6)
        {
            speed = -3;
        }
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
