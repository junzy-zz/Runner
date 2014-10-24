﻿using UnityEngine;
using System.Collections;

public class gameov : MonoBehaviour {

	private float screenHeight;
	private float screenWidth;
	private float buttonHeight;
	private float buttonWidth;
	public Texture2D back;
	public Font font;
	public GUISkin mystyle;
	string score1,LeftCount,RightCount,DownCount,UpCount;
	public Texture gameover;
	public GUIStyle style;

	void Update()
	{
			
		Debug.Log(DelegateMenu.lev);
		if (DelegateMenu.lev == 1){
				score1 = playermovement.score.ToString ();
				} else if (DelegateMenu.lev == 2) {
						LeftCount=playermovement1.LeftCount.ToString();
						RightCount=playermovement1.RightCount.ToString();
						UpCount=playermovement1.UpCount.ToString();
						DownCount=playermovement1.DownCount.ToString();
				score1 = playermovement1.score.ToString ();
				} else if (DelegateMenu.lev == 3) {
						score1 = playermovement2.score.ToString ();
				} else if (DelegateMenu.lev == 4) {
						score1 = playermovement3.score.ToString ();
				}
		}

	void OnGUI(){
		GUI.Label (new Rect(150, -100, screenWidth, screenHeight),gameover);
		GUI.skin = mystyle;
				GUI.skin.box.normal.background = back;
				GUI.skin.font = font;
			//	GUI.Box (new Rect (0, 0, 1400, 700), "");
		screenHeight = Screen.height;
		screenWidth = Screen.width;
		
		buttonHeight = screenHeight * 0.3f;
		buttonWidth = screenWidth * 0.4f;
				
		//GUI.Label (new Rect (screenWidth * 0.35f, screenHeight * 0.25f, screenWidth * 0.5f, screenHeight * 0.2f), "GAME OVER");
		GUI.Label(new Rect (screenWidth * 0.22f, screenHeight * 0.22f, screenWidth * 0.5f, screenHeight * 0.2f), "Score:",style);
		GUI.Label(new Rect(screenWidth * 0.40f, screenHeight * 0.22f, screenWidth * 0.5f, screenHeight * 0.2f),score1,style);

		//junaid
		GUI.Label(new Rect (screenWidth * 0.22f, screenHeight * 0.3f, screenWidth * 0.5f, screenHeight * 0.2f), "Left:",style);
		GUI.Label(new Rect(screenWidth * 0.40f, screenHeight * 0.3f, screenWidth * 0.5f, screenHeight * 0.2f),LeftCount,style);

		GUI.Label(new Rect (screenWidth * 0.22f, screenHeight * 0.4f, screenWidth * 0.5f, screenHeight * 0.2f), "Right:",style);
		GUI.Label(new Rect(screenWidth * 0.40f, screenHeight * 0.4f, screenWidth * 0.5f, screenHeight * 0.2f),RightCount,style);

		GUI.Label(new Rect (screenWidth * 0.22f, screenHeight * 0.5f, screenWidth * 0.5f, screenHeight * 0.2f), "Up:",style);
		GUI.Label(new Rect(screenWidth * 0.40f, screenHeight * 0.5f, screenWidth * 0.5f, screenHeight * 0.2f),UpCount,style);

		GUI.Label(new Rect (screenWidth * 0.22f, screenHeight * 0.6f, screenWidth * 0.5f, screenHeight * 0.2f), "Down:",style);
		GUI.Label(new Rect(screenWidth * 0.40f, screenHeight * 0.6f, screenWidth * 0.5f, screenHeight * 0.2f),DownCount,style);


		//junaid

		if (GUI.Button (new Rect (screenWidth * 0.85f, screenHeight * 0.05f, screenWidth * 0.11f, screenHeight * 0.05f), "Play Again")) {
			Application.LoadLevel ("start");
				}
		if (GUI.Button (new Rect (screenWidth * 0.85f, screenHeight * 0.1f, screenWidth * 0.11f, screenHeight * 0.05f), "High Score")) {
			Application.LoadLevel("HS");
				}
		if (GUI.Button (new Rect (screenWidth * 0.85f, screenHeight * 0.15f, screenWidth * 0.11f, screenHeight * 0.05f), "QUIT")) {
						Application.Quit ();
				}
				//GUI.Button (new Rect (120, 120, 80, 40), "S.NO.");
				//GUI.Button (new Rect (210, 120, 150, 40), "Playername");
		}
}
