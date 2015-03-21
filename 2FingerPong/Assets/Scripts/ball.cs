using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	public float speed = 30;

	// Use this for initialization
	void Start () {
		//init velocity
		GetComponent<Rigidbody>().velocity = Vector2.right * speed;
	}

	void OnCollisionEnter(Collision col){
		//Note: 'col' holds the collision information.
		//If the ball collided with the racket, then:
		//	col.gameObect is the racket
		//	col.transform.position is the racket's position
		//	col.collider is the racket's collider

		//hit the left racket?
		if(col.gameObject.name == "RacketLeft"){
			//calculate hit factor
			float y = hitFactor(transform.position,
			                    col.transform.position,
			                    col.collider.bounds.size.y);

			//calculate direction, make length =1 via normalized
			Vector2 dir = new Vector2(1,y).normalized;

			//set velocity with dir * speed
			GetComponent<Rigidbody>().velocity = dir * speed;
		}
		/*
		//hit the right racket?
		if(col.gameObject.name == "RacketRight"){
			//calculate hit factor
			float y = hitFactor(transform.position,
			                    col.transform.position,
			                    col.collider.bounds.size.y);

			//calculate direciton, make length =1 via normalized
			Vector2 dir = new Vector2(-1,y).normalized;

			//set velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}*/


	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight){
		return (ballPos.y - racketPos.y) / racketHeight;
	}
}
