﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : StateMachineBehaviour {

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		animator.SetFloat("MoveX", Input.GetAxis("Horizontal"));
		animator.SetFloat("MoveZ", Input.GetAxis("Vertical"));
		
		if(Input.GetButtonDown("Jump"))
		{
			animator.SetTrigger("Jump");
		}

		if(Mathf.Abs(animator.GetFloat("MoveX")) + Mathf.Abs(animator.GetFloat("MoveZ")) > 0)
		{
			animator.SetBool("PlayerMoving", true);
		}
		else
		{
			animator.SetBool("PlayerMoving", false);
		}
	}

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	//override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
	//
	//}

	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
	//override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	//
	//}
}
