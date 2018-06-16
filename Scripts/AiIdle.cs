﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Idle", menuName = "Ai/Function/Idle")]
public class AiIdle : AiBase {
	
	public override void Navigate(NavMeshAgent ai)
	{
		ai.speed = Speed.Value;
		ai.angularSpeed = AngularSpeed.Value;
	}
}
