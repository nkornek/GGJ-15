using UnityEngine;
using System.Collections;

public class PointNclick : MonoBehaviour {

	public Camera currentCam;
	public Animator cameraAnimator;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		RaycastHit hit;

		Ray ray = currentCam.ScreenPointToRay(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 100));

		if (Input.GetMouseButtonDown(0) & Physics.Raycast (ray, out hit)) 
		{
			//clicked an object
			cameraAnimator.SetTrigger(hit.transform.tag);
		}
	}
}
