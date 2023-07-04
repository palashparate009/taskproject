using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody rb;
    public GameObject player;
    public int speed;
    public Animator anim;
    public float jumpHeight = 70f;
    public bool isGrounded;
    public float timer;
    public GameObject panel;
    public GameObject timertextref;
    public GameObject levelcompletepanel;
    //public GameObject pivot;
    public List<GameObject> cubelist;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if ((Input.GetKey(KeyCode.W)))
        {
            Move(Vector3.forward);
            anim.SetBool("running", true);
            // anim.SetInteger("Run",0);

        }
        else if ((Input.GetKey(KeyCode.S)))
        {
            Move(Vector3.back);
            //anim.SetBool("Run", true);
            anim.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
            //anim.SetBool("Run", true);
            anim.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {

            Move(Vector3.right);
            // anim.SetBool("Run", true);
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }

        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpHeight);
            }
        }
        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //        pivot.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);

        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    playerrotation();
        //}
        if(cubelist.Count>=5)
        {
            levelcompletepanel.SetActive(true); 
        }
    }
    //void playerrotation()
    //{
    //    player.transform.Rotate(new Vector3(0f, 0f, 90f), Space.World);

    //}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            anim.SetBool("freefall", false);
        }
        if(other.gameObject.tag=="cubes")
        {
            other.gameObject.SetActive(false);
            cubelist.Add(gameObject);
            Debug.Log(cubelist.Count);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "triggerobj")
        {
            //Debug.Log("gg");
            panel.SetActive(true);
            timertextref.SetActive(false);  

        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
            anim.SetBool("freefall", true);
        }
    }
    public void Move(Vector3 dir)
    {
        player.transform.Translate(dir * speed * Time.deltaTime);
    }
}

