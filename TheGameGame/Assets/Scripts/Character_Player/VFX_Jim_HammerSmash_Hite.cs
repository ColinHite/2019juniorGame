/// <summary>
/// This script controls the effect timing and use of Jim's hammer down charge attack.
/// 
/// Author: Colin Hite
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_Jim_HammerSmash_Hite : MonoBehaviour {

	//This keeps track of all jim's prefabs needed to do the hammer charge attack.
	public GameObject[] attackDown;

	//public int VFX_array_index;

	//This line defines the parent used to reset the effect to the player object
	public GameObject vfx_parent;

	//Public reference to class elementManager
	public ElementManager elementManager;

	public void Start()
	{
		//Find the player and get its script
		elementManager = GameObject.FindWithTag("Player").GetComponent<ElementManager>();
	}

	//This method is used to call the series of events needed to do the hammer charge attack
	public void HammerVFX_Call()
	{
		//checks ElementManager for current element to determine what element VFX to use
		HammerVFX_On (attackDown [(int)elementManager.currentElement - 1]);
	}
	//This method turns the effect on
	public void HammerVFX_On(GameObject currentVFX)
	{
		//yield return new WaitForSeconds (0.1f);
		currentVFX.SetActive (true);
		currentVFX.transform.SetParent (null);
		StartCoroutine (HammerVFX_Off (currentVFX));
	}
	//This method turns the effect off
	public IEnumerator HammerVFX_Off(GameObject VFXpass)
	{
		yield return new WaitForSeconds (7.0f);
		VFXpass.SetActive (false);
		VFXpass.transform.SetParent (vfx_parent.transform);
		VFXpass.transform.localPosition = new Vector3 (0, 0, 0);
		VFXpass.transform.localRotation = new Quaternion (0, 0, 0, 0);
	}
}
