using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMoviment moviment;

	void OnCollisionEnter (Collision collisionInfo)
	{

		if (collisionInfo.collider.tag == "Obstacle")
		{

			moviment.enabled = false;

		}
	}


}
