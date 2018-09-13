using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour {


	public Player playerScript;
	// Use this for initialization
	void Start () {
		playerScript = GameObject.FindWithTag ("Player").GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LeftButton()
	{
		playerScript.LeftButton ();
	}
	public void RightButton()
	{
		playerScript.RightButton ();
	}
	public void UpButton()
	{
		playerScript.UpButton ();
	}
	public void DownButton()
	{
		playerScript.DownButton ();
	}

	public void FireButton()
	{
		playerScript.FireButton ();
	}
}
