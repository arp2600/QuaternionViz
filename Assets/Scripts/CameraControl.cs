using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour 
{
	public float rotation_speed = 100;
	public float zoom_speed = 10;
	
	void Update () 
	{
		float rotation = 0;
		if (Input.GetKey("left"))
			rotation += 1;
		if (Input.GetKey("right"))
			rotation -= 1;
		transform.RotateAround(Vector3.zero, transform.up, rotation*rotation_speed *Time.deltaTime);

		rotation = 0;
		if (Input.GetKey("up"))
				rotation += 1;
		if (Input.GetKey("down"))
				rotation -= 1;
		transform.RotateAround(Vector3.zero, transform.right, rotation*rotation_speed *Time.deltaTime);

		rotation = 0;
		if (Input.GetKey("c"))
				rotation += 1;
		if (Input.GetKey("v"))
				rotation -= 1;
		transform.Rotate(Vector3.forward, rotation*rotation_speed *Time.deltaTime);

		float zoom = 0;
		if (Input.GetKey("z"))
			zoom += 1;
		if (Input.GetKey("x"))
			zoom -= 1;

		transform.Translate(Vector3.forward * zoom * zoom_speed * Time.deltaTime);
	}
}
