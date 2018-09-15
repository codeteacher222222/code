using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Mobile3DControl : MonoBehaviour {

	public float speed = 6.0f;
	public float rotSpeed = 20.0f;
	// Use this for initialization
	void Start () {
		GetComponent<Player> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		// pass the input to the car!
		//DualTouchControls로 시작
		float h = CrossPlatformInputManager.GetAxis("Horizontal");
		float v = CrossPlatformInputManager.GetAxis("Vertical");
		float a = CrossPlatformInputManager.GetAxis("Mouse X");
		float b = CrossPlatformInputManager.GetAxis("Mouse Y");
		Debug.Log (h+":"+v+":"+a+":"+b);
		#if !MOBILE_INPUT
		float handbrake = CrossPlatformInputManager.GetAxis("Jump");
		m_Car.Move(h, v, v, handbrake);
		#else
		Vector3 moveVec3 = Vector3.zero;
		moveVec3 += transform.right * h;
		moveVec3 += transform.forward * v;

		transform.position += (moveVec3 * speed * Time.deltaTime);
		transform.rotation = Quaternion.Euler(
			transform.rotation.eulerAngles.x + (b* rotSpeed * Time.deltaTime),
			transform.rotation.eulerAngles.y + (a* rotSpeed * Time.deltaTime),
			.0f
		);
		#endif
	}
}
