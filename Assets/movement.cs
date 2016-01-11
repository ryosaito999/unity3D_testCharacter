using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    Rigidbody rb;
    public float speed;
    public float jumpForce;

    float tmpMovex = 0;
    float tmpMovez = 0;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update () {

        
        float movex = Input.GetAxis("Horizontal");
        float movez = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(movex * speed, rb.velocity.y, movez * speed); ;



        bool jump = Input.GetKeyDown("space");
        if(jump)
        {
            Debug.Log("jumping");
            rb.AddForce(Vector3.up * jumpForce);
        }

    }
}
