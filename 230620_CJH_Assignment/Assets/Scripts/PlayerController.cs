using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    bool lable;
    bool rable;

    int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lable == true)
        {
            L_Move();
        }
        
        if(rable == true)
        {
            R_Move();
        }
    }

    public void LeftMove()
    {
        lable = true;
        rable = false;
    }

    public void RightMove()
    {
        lable = false;
        rable = true;
    }

    public void L_Move()
    {
        if(player.transform.position.x > -2f)
        {
            speed = 1;
            player.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if(player.transform.position.x < -2f)
        {
            speed = 0;
        }
    }

    public void R_Move()
    {
        if(player.transform.position.x < 2f)
        {
            speed = 1;
            player.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if(player.transform.position.x > 2f)
        {
            speed = 0;
        }
    }
}
