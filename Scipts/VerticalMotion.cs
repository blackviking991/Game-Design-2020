using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotion : MonoBehaviour
{
    public int speed;
    float initialpos;
    // Start is called before the first frame update
    void Start()
    {
        initialpos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= initialpos - 3)
        {
            speed = 3;
        }
        if (transform.position.y >= initialpos + 3)
        {
            speed = -3;
        }
        transform.Translate(0,speed*Time.deltaTime, 0);
    }
}
