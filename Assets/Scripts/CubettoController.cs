using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubettoController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed = 1f;

    // Update is called once per frame{}
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            rb.MovePosition(rb.position + Vector3.forward * speed * Time.deltaTime);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);    
    }

}
