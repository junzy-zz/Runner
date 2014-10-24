﻿using UnityEngine;
using System.Collections;


public class highscore : MonoBehaviour {

	private float screenHeight;
	private float screenWidth;
	private float buttonHeight;
	private float buttonWidth;
	public Texture2D back;
	public Font font;
	public GUIStyle mystyle;
	public GUISkin mystyle1;



	void OnGUI(){
		screenHeight = Screen.height;
		screenWidth = Screen.width;
		GUI.skin.box.normal.background = back;
		GUI.skin.font = font;
		//GUI.Box (new Rect(0,0,1400,700),"");
		GUI.Label(new Rect (380,0,200,150),"High Score",mystyle);
		GUI.Label(new Rect (10,120,200,80),"S.NO.");
		GUI.Label(new Rect (150,120,250,80),"Playername");
		GUI.Label(new Rect (390,120,200,80),"Score");
		GUI.Label(new Rect (540,120,200,80),"Distance");
		GUI.Label(new Rect (740, 120, 200, 80), "LeftTurn");
		GUI.Label(new Rect (980, 120, 200, 80), "RightTurn");
		GUI.Label(new Rect (1210, 120, 200, 80), "TimePlay");
		GUI.Label(new Rect (1450, 120, 200, 80), "Date");
		if(GUI.Button(new Rect (1100,20,200,60),"BACK"))
		{
			Application.LoadLevel("start");
		}
		GUI.Label(new Rect (30,190,120,60),"1.");
		GUI.Label(new Rect (160,190,250,60),coindelete.Line[0]);
		//Debug.Log(coindelete.Line[0]);
		GUI.Label(new Rect (410,190,200,60),coindelete.Line[1]);
		GUI.Label(new Rect (570,190,200,60),coindelete.Line[2]);
		GUI.Label(new Rect (760,190, 200,60), coindelete.Line [3]);
		GUI.Label(new Rect(990, 190, 200,60),coindelete.Line[4]);
		GUI.Label(new Rect(1240, 190, 200,60),coindelete.Line[5]);
		GUI.Label(new Rect(1450, 190, 450,60),coindelete.Line[6]);
		GUI.Label(new Rect (30,260,120,60),"2.");
		GUI.Label(new Rect (160,260,250,60),coindelete.Line[7]);
		GUI.Label(new Rect (410,260,200,60),coindelete.Line[8]);
		GUI.Label(new Rect (570,260,200,60),coindelete.Line[9]);
		GUI.Label(new Rect (760, 260, 200, 60), coindelete.Line [10]);
		GUI.Label (new Rect (990, 260, 200, 60), coindelete.Line [11]);
		GUI.Label(new Rect(1240, 260, 200,60),coindelete.Line[12]);
		GUI.Label(new Rect(1450, 260, 400,60),coindelete.Line[13]);
		GUI.Label(new Rect (30,330,120,60),"3.");
		GUI.Label(new Rect (160,330,250,60),coindelete.Line[14]);
		GUI.Label(new Rect (410,330,200,60),coindelete.Line[15]);
		GUI.Label(new Rect (570,330,200,60),coindelete.Line[16]);
		GUI.Label (new Rect(760, 330, 200,60),coindelete.Line[17]);
		GUI.Label(new Rect( 990,330,200,60),coindelete.Line[18]);
		GUI.Label(new Rect(1240, 330, 200,60),coindelete.Line[19]);
		GUI.Label(new Rect(1450, 330, 400,60),coindelete.Line[20]);
		GUI.Label(new Rect (30,400,120,60),"4.");
		GUI.Label(new Rect (160,400,250,60),coindelete.Line[21]);
		GUI.Label(new Rect (410,400,200,60),coindelete.Line[22]);
		GUI.Label(new Rect (570,400,200,60),coindelete.Line[23]);
		GUI.Label (new Rect (760, 400, 200,60),coindelete.Line [24]);
		GUI.Label (new Rect (990, 400, 200, 60), coindelete.Line [25]);
		GUI.Label(new Rect(1240, 400, 200,60),coindelete.Line[26]);
		GUI.Label(new Rect(1450, 400, 400,60),coindelete.Line[27]);
		GUI.Label(new Rect (30,470,120,60),"5.");
		GUI.Label(new Rect (160,470,250,60),coindelete.Line[28]);
		GUI.Label(new Rect (410,470,200,60),coindelete.Line[29]);
		GUI.Label(new Rect (570,470,200,60),coindelete.Line[30]);
		GUI.Label (new Rect (760, 470, 200, 60), coindelete.Line [31]);
		GUI.Label (new Rect (990, 470, 200, 60), coindelete.Line [32]);
		GUI.Label(new Rect(1240, 470, 200,60),coindelete.Line[33]);
		GUI.Label (new Rect (1450, 470, 400, 60), coindelete.Line [34]);
       



}
}
