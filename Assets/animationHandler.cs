using UnityEngine;
using System.Collections;

public class animationHandler : MonoBehaviour {
    Animator anim;
    float counter;
    string animation_name;
    public float idleSecNum;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        counter = 0;
    }

    void updateIdle()
    {
        //anim.Play("WAIT00");
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("WAIT00"))
        {
            counter += Time.deltaTime;
        }
    }

    void playIdle()
    {
        float rand = Random.Range(0, 4);
        if (rand == 0)
        {
            animation_name = "WAIT01";
        }
        if (rand == 1)
        {
            animation_name = "WAIT02";
        }
        if (rand == 2)
        {
            animation_name = "WAIT03";
        }
        if (rand == 3)
        {
            animation_name = "WAIT04";
        }

        anim.Play(animation_name);
    }


    // Update is called once per frame
    void Update () {
        float moveInputX = Input.GetAxisRaw("Horizontal");
        float moveInputY = Input.GetAxisRaw("Vertical");
        anim.SetFloat("inputX", moveInputX);
        anim.SetFloat("inputY", moveInputY);

        bool jump = Input.GetKeyDown("space");

        if (moveInputX != 0 || moveInputY != 0)
        {
            counter = 0;
        }

        if( moveInputX > 0 && moveInputX == 0)
        {

        }



        else {
            updateIdle();
            if (counter >= idleSecNum)
            {
                playIdle();
                counter = 0;
            }
        }
    


    }
}
