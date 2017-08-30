using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ServerManager {

	public static Player GetNewPlayer ()
	{
		Player player = new Player();
		player.flag = new Flag();
		player.flag.playerNum = 5;
		player.ID = player.flag.playerNum;
		return player;
	}
}

	
