using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnCollision2D(GameObject other){
		// Delete our Platforms as they fall
		if (other.gameObject.CompareTag ("Platform")) {
			Destroy(other);
		}
	}
}
