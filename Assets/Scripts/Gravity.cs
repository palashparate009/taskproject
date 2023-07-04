using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject pivot;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pivot.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);
            Physics.gravity = new Vector3(0f, 0f ,-1f);
            //pivot.transform.up= Physics.gravity;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pivot.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);
            Physics.gravity = new Vector3(0f, 9.8f, 0f);
            //pivot.transform.up= Physics.gravity;

        }

    }
}
