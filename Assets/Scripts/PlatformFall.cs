using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 1f;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();	// Search for component and set
	}											// our instance of rb2d to our Game Objects.

	// If our colliders make contact with another player called tag,
	// then for this instance of our object(i.e. a platform), call
	// a function called "Fall" after 'fallDelay" (i.e. invoke a function after x seconds).
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Player")) {
			Invoke("Fall",fallDelay);
		}
	}
	// Make our object fall by turning off isKinematic.
	void Fall(){
		rb2d.isKinematic = false;
	}
}
