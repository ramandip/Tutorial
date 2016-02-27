using UnityEngine;
using System.Collections;

public class GemManager : MonoBehaviour {

	/// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;
	
	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed, 0);
		this._transform.position = this._currentPosition;

		//Reuse objects that are out of sight

	}
	
	public void Reset() {
		//Provide implementation for the Reset function
	}
}
