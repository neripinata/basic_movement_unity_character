using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

    
{
    public float speedx = 10f;
    public float speedz = 10f;
    public float speedy = 10f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //Personaje movimiento
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal") * speedx;
        horizontal *= Time.deltaTime;
        if (moveX != 0 || moveY != 0)
        {
            animator.SetFloat("speed", 1);
        }
        else
        {
            animator.SetFloat("speed", 0);
        }
        Debug.Log(moveX);
        Debug.Log(moveY);


        float diagonal = Input.GetAxis("Vertical") * speedz;
        diagonal *= Time.deltaTime;

        //float vertical = Input.GetAxis("Jump") * speedy;
        //vertical *= Time.deltaTime;

        transform.Translate(horizontal, 0, 0);
        transform.Translate(0, 0, diagonal);
        //transform.Translate(0, vertical, 0);


        





    }

    
}
