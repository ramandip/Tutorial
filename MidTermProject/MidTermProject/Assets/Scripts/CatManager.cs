﻿using UnityEngine;
using System.Collections;

public class CatManager : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;
	
	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();
		
		// Reset the Island Sprite to the Top
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		//Move and reuse object
	}
	
	public void Reset() {
		//Provide implementation for the Reset function
	}
}
