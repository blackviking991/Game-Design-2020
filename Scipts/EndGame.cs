using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
      if (transform.position.y > 10 || transform.position.y < -9)
            {
                SceneManager.LoadScene(2);
            }
        
    }
}
