using UnityEngine;
using System.Collections;

public class CubePlayerMovement : MonoBehaviour {

	public float aSpeed = 3.0f;
	public Animation cubeAnimation;


	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, 0, Time.deltaTime * aSpeed);
		print ("trasnform position" + transform.position);
		jump ();
	}

	void jump(){
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			cubeAnimation.Play("JumpUpAnimation");
		}
	}
}
