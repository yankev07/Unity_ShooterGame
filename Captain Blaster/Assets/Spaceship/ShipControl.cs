using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public float playerSpeed = 10f;
	public GameControl gameController;
	public GameObject bulletPrefab;
	public float reloadTime = 0.5f; // Fire a bullet every half-second

	private float elapsedTime = 0;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime; // 

		// Move the player left and right
		float xMovement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
		float xPosition = Mathf.Clamp (xMovement, -7f, 7f); // Keep ship on screen
		transform.Translate(xPosition, 0f, 0f);


		// Spacebar fires. The defalut inputManager settings call this "Jump"
		//Only happens if enough time has elapsed since last firing
		if(Input.GetButtonDown("Jump")&& elapsedTime > reloadTime){
			// Instantiate the bullet 1.2 units in front of the player
			// and in the foreground at z = -5
			Vector3 spawnPos = transform.position;
			spawnPos += new Vector3 (0, 2f, 0);
			Instantiate (bulletPrefab, spawnPos, Quaternion.identity);

			elapsedTime = 0f; // Reset bullet firing timer
		}
	}

	//If a meteor hits the player
	void OnTriggerEnter2D(Collider2D other){
		gameController.PlayerDied ();
	}
}
