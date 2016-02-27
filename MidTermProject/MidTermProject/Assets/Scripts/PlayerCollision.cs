using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources;
	private AudioSource _islandSound;
	private AudioSource _cloudSound;
	
	// PUBLIC INSTANCE VARIABLES
	public UIController gameController;
	
	// Use this for initialization
	void Start () {
		// Initialize the audioSources array
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._cloudSound = this._audioSources [1];
		this._islandSound = this._audioSources [2];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*Implement function that will:

	- Collect gem (reuse object)
	- Add points when gem collected
	- Decrease life number if collided with jey or cat 
	- Debug.Log each collision
	 */

}
