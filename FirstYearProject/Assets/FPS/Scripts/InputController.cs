using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
	public float speed = 10F;
	public float rotationSpeed = 2.0F;

	float pitch;
	float yaw;


	void Update()
	{
		float translationZ = Input.GetAxisRaw("Vertical") * speed;
		float translationX = Input.GetAxisRaw("Horizontal") * speed;
		translationZ *= Time.deltaTime;
		translationX *= Time.deltaTime;

		transform.Translate(translationX, 0, translationZ);


		// camera lookat
		if (Input.GetMouseButton(0))
		{
			pitch += rotationSpeed * Input.GetAxis("Mouse Y");
			yaw += rotationSpeed * Input.GetAxis("Mouse X");

			// Clamp pitch:
			pitch = Mathf.Clamp(pitch, -90f, 90f);

			// Wrap yaw:

			while (yaw < 0f)
			{
				yaw += 360f;
			}
			while (yaw >= 360f)
			{
				yaw -= 360f;
			}


			// Set orientation:
			transform.eulerAngles = new Vector3(-pitch, yaw, 0f);
		}
	}
}