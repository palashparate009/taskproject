using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer;
    public GameObject panel;
    public GameObject timertextref;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer >= 120f)
        {
            panel.SetActive(true);
            timertextref.SetActive(false);
        }


    }

}
