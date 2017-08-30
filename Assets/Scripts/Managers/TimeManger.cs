using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeManger : MonoBehaviour {
	public static float time = 0;
	public Text text;
	public static float startTime = 0;
	void Update ()
	{
		
		time += Time.deltaTime;
		text.text = time + "";


		if(AssignQ.sizeQ > 0)
			GameManager.gm.TimeToAssign.text = TimeManger.startTime + 3 - TimeManger.time +"";
		if (time - startTime >= 3 && AssignQ.sizeQ > 0 && GameManager.gm.isAssigning) {

			Vector2 v = AssignQ.Get();
			AssignQ.sizeQ--;
			if(AssignQ.sizeQ <= 0)
				GameManager.gm.isAssigning = false;
			GameManager.gm.increaseCellNum((int) v.y ,(int) v.x);
			startTime = time;
		}
	}
}
