using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform Player;
    public Collider PlayerCol;
    public bool Flag = false;
    float x = 0;
    float Speed = 0.5f;

    public Rigidbody Rgb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flag = true;
            Rgb.useGravity = false;
            PlayerCol.isTrigger = true;
        }

        if(Flag == true)
        {
            Debug.LogError("STOP" +  Player.rotation);
            if (Player.rotation.x <= 90)
            {
                x += Speed * Time.deltaTime;
                Player.Rotate(new Vector3(x, 0, 0));
            }
            else
            {
                Flag = false;
                Rgb.useGravity = true;
            }
        }

    }
}
