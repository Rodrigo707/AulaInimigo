using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

   [SerializeField] private Vector2 speed;

	/*	void update (){
	if(gameObject.name == "Bullet(Clone)"){
		Destroy(gameObject, 3);
	}
} */
	    void FixedUpdate(){
        GetComponent<Rigidbody2D>().velocity = speed;
        }

	void OnTriggerEnter2D (Collider2D enemy){
				if (enemy.CompareTag ("Enemy")) {
						Destroy (enemy.gameObject);
				}
		}
}