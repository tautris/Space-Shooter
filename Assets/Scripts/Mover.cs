using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rigidBody;

    public float speed;
    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.velocity = transform.forward * speed;
    }
}
