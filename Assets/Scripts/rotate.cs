using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class rotate : MonoBehaviour {
	public float speed = 250f;
	public bool isRotating = false;

	void Update ()
	{
		if (Input.GetKey (KeyCode.F))
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.H))
			transform.Rotate (-Vector3.up * speed * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Y)) {
			transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
		}
		if (Input.GetKey (KeyCode.T)) {
			transform.Rotate(-Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.G)) {
			transform.Rotate(Vector3.right * speed * Time.deltaTime);
		}
	}

}
