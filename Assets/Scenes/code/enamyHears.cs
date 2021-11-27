using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enamyHears : MonoBehaviour
{
    float h = 1f;
    float delay;
    void OnTriggerStay2D (Collider2D col)
    {
       if (delay < Time.time)
       {
         GameControlScript.health -= h;
         delay = Time.time +1;
       }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
