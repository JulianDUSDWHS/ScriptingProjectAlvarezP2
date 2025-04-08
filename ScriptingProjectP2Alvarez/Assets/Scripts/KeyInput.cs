using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down == true)
        {
            Debug.Log("keydown");
        }
        else if (held == true)
        {
            Debug.Log("keyheld");
        }
        else if (up == true)
        {
            Debug.Log("keyup");
        }
        else
        {
            Debug.Log("key");
        }
    }
}
