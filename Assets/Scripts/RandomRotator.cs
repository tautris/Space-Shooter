using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    private Rigidbody rigidBody;
    public float tumble;

	void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.angularVelocity = Random.insideUnitSphere * tumble;
    }

}
