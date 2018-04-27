using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_animation : MonoBehaviour {
	enum Joint
	{
		_HandR = 0, _ArmR, _UpperArmR,
		_HandL, _ArmL, _UpperArmL,
		_FootR, _LegR, _UpperLegR,
		_FootL, _LegL, _UpperLegL,
		_Nect, _Head
	}
	class Calculate
	{
		//private int cal[] = new int[Joint.
	}

	public int Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//GameObject targetObject;
		//targetObject = GameObject.Find ("UpperArmR");
		//Vector3 temp = new Vector3( 0, 60, 180);
		//targetObject.transform.Rotate(temp);
		//targetObject.transform.Rotate(new Vector3( 1, Speed, 0) * Time.deltaTime);
		transform.Rotate(new Vector3( 1, Speed, 0) * Time.deltaTime);
	}
}