using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	public static void cellClick (Cell c)
	{
		if (c.Permission [GameManager.gm.player.flag.playerNum] && GameManager.gm.player.freeSoldiers > 0) 
		{
			int x = (int)c.pos.x, y = (int)c.pos.y, firstTimeAssign = 0;

			GameManager.gm.player.freeSoldiers -= 1;
			GameManager.gm.TFreeSoldier.text = GameManager.gm.player.freeSoldiers + "";

			AssignQ.Set (new Vector2 (y, x));

			if (AssignQ.sizeQ == 0)
				firstTimeAssign++;
			AssignQ.sizeQ++;
			if (AssignQ.sizeQ == 1)
				firstTimeAssign++;
			if (AssignQ.sizeQ > 0)
				GameManager.gm.isAssigning = true;
			if (firstTimeAssign == 2)
				TimeManger.startTime = TimeManger.time;
		}
	}
}
