using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalRotate : MonoBehaviour
{
    public Transform Center;
    public float AngularSpeed, radius;
    private float posx,posy,angle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        posx = Center.position.x + Mathf.Cos(angle)*radius;
        posy = Center.position.y + Mathf.Sin(angle)*radius;
        transform.position = new Vector2(posx,posy);
        angle = angle + Time.deltaTime*AngularSpeed;
        if (angle >= 360)
        {
            angle = 0;
        }
    }
}
