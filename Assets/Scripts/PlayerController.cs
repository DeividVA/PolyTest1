using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpTime = 0.967f;
    bool isGrounded = true;
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
      
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame{}
    void FixedUpdate()
    {
        _animator.SetBool("IsRunning", Input.GetKey(KeyCode.UpArrow));
        _animator.SetBool("IsJumping", Input.GetKeyDown(KeyCode.Space) && isGrounded);

        if (_animator.GetBool("IsJumping")) 
        { 
            isGrounded = false;
        }

        if (!isGrounded)
        {
            jumpTime -= Time.deltaTime;
        }

        if (jumpTime <= 0) 
        { 
            isGrounded=true;
            jumpTime = 0.967f;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);    
    }

}
