using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;
	//add more variables if needed



	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;


	
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();
		
		// Reset the Ocean Sprite to the Top
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		//Implement infinit scroll for the background with a minimum jumping
	}
	
	public void Reset() {
		this._transform.position = new Vector2 (315, 0f);
	}
}
