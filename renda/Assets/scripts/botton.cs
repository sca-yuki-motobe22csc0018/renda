using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botton : MonoBehaviour
{
    bool click = false;
    float startcount=3;
    bool start=false;
    float colorTimer = 0;
    int count = 0;
    public Text scoreText;


    void Start()
    {
        scoreText.text="";
    }

    void Update()
    {
        scoreText.text=count.ToString();
        colorTimer+=1;
        if (click)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.gray;
            ++count;
            click=false;
            colorTimer=0;
        }
        else
        {
            if (colorTimer >= 20)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                colorTimer=0;
            }
            
        }
    }

    private void OnMouseDown()
    {
        click=true;
    }
}
