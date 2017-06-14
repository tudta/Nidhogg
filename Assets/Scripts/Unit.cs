using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Unit : MonoBehaviour {
    private float moveSpeed = 0.0f;
    private float jumpPower = 0.0f;
    private Rigidbody rb = null;

    public virtual void Awake() {

    }

	// Use this for initialization
	public virtual void Start () {
        Init();
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
	}

    public virtual void Init() {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Move(Vector3 direction) {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    public virtual void Jump() {
        rb.AddForce(Vector3.up * jumpPower);
    }
}
