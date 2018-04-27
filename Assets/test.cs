using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	void ProcessSkeleton (nuitrack.Skeleton skeleton)    
	{    
		Vector3 torsoPos = Quaternion.Euler (0f, 180f, 0f) * (0.001f * skeleton.GetJoint (nuitrack.JointType.Torso) .ToVector3 ());
		transform.position = torsoPos;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CurrentUserTracker.CurrentSkeleton!= null)
			ProcessSkeleton (CurrentUserTracker.CurrentSkeleton);
	}
}
