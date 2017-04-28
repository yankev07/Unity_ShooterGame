using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 10f;
	private GameControl gameController;
	// Use this for initialization
	void Start () {
		// Because the bulletr doesn't exist until the game is running
		//WE must find the game Controller a different way
		gameController = GameObject.FindObjectOfType<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0f, speed * Time.deltaTime, 0f); // Move up

	}

	void OnCollisionEnter2D(Collision2D other){

		Destroy (other.gameObject); // DESTROY THE METEOR
		gameController.AddScore(); // Increment the score
		Destroy(gameObject); //Destroy the bullet
	}
}
