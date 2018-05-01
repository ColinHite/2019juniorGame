/// <summary>
/// This script controls the on and off state for the attack VFX trail used on Jim's model
/// 
/// Author: Colin Hite
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrail_Jim_Hite : MonoBehaviour {
		
	//public int VFX_array_index;

	//This is used to keep track of the prefabs uded on the axe
	public GameObject[] attackTrail;

	//Public reference to class elementManager
	public ElementManager elementManager;

	public void Start()
	{
		//Find the player and get its script
		elementManager = GameObject.FindWithTag("Player").GetComponent<ElementManager>();
		print("Attack VFX " + elementManager);
	}

	//This method is used to call the series of events needed for the trail to appear and disappear
	public void TrailVFX_Call()
	{
		//checks ElementManager for current element to determine what element VFX to use
		TrailVFX_On (attackTrail [(int)elementManager.currentElement - 1]);
		print("element number " + ((int)elementManager.currentElement - 1));
	}

	//This method turns the effect trail on
	public void TrailVFX_On(GameObject currentVFX)
	{
		currentVFX.SetActive (true);
		StartCoroutine (attackTrail_Off (currentVFX));
	}
	//This method is a timer to turn the trail off.
	public IEnumerator attackTrail_Off(GameObject VFXpass)
	{
		yield return new WaitForSeconds (0.9f);
		VFXpass.SetActive (false);
	}
}