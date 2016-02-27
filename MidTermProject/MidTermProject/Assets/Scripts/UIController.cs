using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;
	
	[SerializeField]
	private AudioSource _gameOverSound;
	
	// PUBLIC ACCESS METHODS
	public int ScoreValue {
		get {
			return this._scoreValue;
		}
		
		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}
	
	public int LivesValue {
		get {
			return this._livesValue;
		}
		
		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "lives: " + this._livesValue;
			}
		}
	}
	
	// PUBLIC INSTANCE VARIABLES
	public int cloudNumber = 3;
	public JeyManager jey;
	public CatManager cat;
	public PlayerManager bird;
	public GemManager gem;
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;
	
	// Use this for initialization
	void Start () {
		this._initialize ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//PRIVATE METHODS ++++++++++++++++++
	
	//Initial Method
	private void _initialize() {
		this.ScoreValue = 0;
		this.LivesValue = 5;

		//Make sure that:
		//bird, cat, jey and gems are visible and working
		//Game over label, high score and button are not visible


	}
	
	private void _endGame() {
		//Display information about score earned
		//Show game over label, high score label and button
		//Make sure that bird, cat, jey and gems are not visible and do not interact

	}
	
	// PUBLIC METHODS
	
	public void RestartButtonClick() {
		Debug.Log ("Restart");
		//Implement restrat of the game
	}
}
