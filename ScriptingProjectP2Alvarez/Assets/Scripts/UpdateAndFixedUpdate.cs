using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    void Update ()
    {
      Debug.Log("Update time :" + Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
