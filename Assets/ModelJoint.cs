﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class ModelJoint {
	
	public Transform bone;
	public nuitrack.JointType jointType;
	[HideInInspector] public Quaternion baseRotOffset;

}
