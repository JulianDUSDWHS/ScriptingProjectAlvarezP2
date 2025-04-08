using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down==true)
        {
            Debug.Log("down");
        }
        else if (held==true)
        {
            Debug.Log("held");
        }
        else if (up==true)
        {
            Debug.Log("up");
        }
        else
        {
            Debug.Log("button");
        }
    }
}
