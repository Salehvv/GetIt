using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager gm;
	public GameObject grid;
	public RectTransform scrollBound;
	public int cellSize;
	public Text TFreeSoldier;
	public Text TimeToAssign;
	public Player player;
	public bool isAssigning;

	void Start ()
	{
		// GameManager Instance
		gm = this;

		//AssignQSize
		AssignQ.sizeQ = 0;

		// Grid
		Grid g = grid.GetComponent<Grid> ();
		g.init ();
		grid.GetComponent<GridLayoutGroup> ().cellSize = new Vector2 (cellSize, cellSize);
		grid.GetComponent<GridLayoutGroup> ().spacing = new Vector2 (cellSize / 10, cellSize / 10);
		grid.GetComponent<GridLayoutGroup> ().padding = new RectOffset (cellSize / 10, 0, cellSize / 10, 0);
		scrollBound.sizeDelta = new Vector2 ((g.width + cellSize / 10) * cellSize + (cellSize / 5) 
			, (g.width + cellSize / 10) * cellSize + (cellSize / 5));

		// Player
		player = ServerManager.GetNewPlayer ();
		if (player.flag.playerNum == 0) {
			player.flag.color = Color.blue;
			Grid.setFirstcell(6 , 11 , player);
		}
		if (player.flag.playerNum == 1) {
			player.flag.color = Color.cyan;
			Grid.setFirstcell(6 , 20 , player);
		}
		if (player.flag.playerNum == 2) {
			player.flag.color = Color.gray;
			Grid.setFirstcell(11 , 25 , player);
		}
		if (player.flag.playerNum == 3) {
			player.flag.color = Color.green;
			Grid.setFirstcell(20 , 25 , player);
		}
		if (player.flag.playerNum == 4) {
			player.flag.color = Color.red;
			Grid.setFirstcell(25 , 20 , player);
		}
		if (player.flag.playerNum == 5) {
			player.flag.color = Color.yellow;
			Grid.setFirstcell(25 , 10 , player);
		}
		if (player.flag.playerNum == 6) {
			player.flag.color = Color.magenta;
			Grid.setFirstcell(20 , 6 , player);
		}
		if (player.flag.playerNum == 7) {
			player.flag.color = Color.yellow;
			Grid.setFirstcell(11 , 6 , player);
		}


		//Free soldier Text
		TFreeSoldier.text = player.freeSoldiers + "";


	}



	public void increaseCellNum (int x , int y)
	{
		Grid.cells [y, x].increment ();
		Grid.setPermission (x, y, GameManager.gm.player.flag.playerNum);

	}
}
