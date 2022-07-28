using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    private float waitTime;


    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Drop"))
        {
            waitTime = 0.5f;
        }

        if (Input.GetButtonDown("Drop")){
            if(waitTime <= 0)
            {
                effector.rotationalOffset = 170f;
                waitTime = 0.5f;
            }else {
                waitTime -= Time.deltaTime;

            }
        }

        if (Input.GetButtonDown("Jump")){
            effector.rotationalOffset = 0;
        }
    }
}
