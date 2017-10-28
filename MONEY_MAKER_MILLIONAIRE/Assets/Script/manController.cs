using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manController : MonoBehaviour {
	public float speed = 1.0f;
	public Animator anim;
	public Rigidbody2D rigid;
	public bool walk = true;

	// Use this for initialization
	void Start () {
		if (rigid == null) {
			rigid = GetComponent<Rigidbody2D> ();
		}
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			walk = false;
			speed = 0;
		}
	}

	void FixedUpdate(){
		if (walk)
			rigid.velocity = new Vector2 (speed, rigid.velocity.y);
		else {
			anim.SetInteger ("movement", 1);
			rigid.position = transform.position;
			rigid.velocity = new Vector2 (0, rigid.velocity.y);
			StartCoroutine (Wait());
		}
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (0.4f);
		anim.enabled = false;
	}


}
