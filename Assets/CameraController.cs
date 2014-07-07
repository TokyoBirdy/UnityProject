using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y,target.transform.position.z-10.0f);
	}



		
	}
