using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
	public int width = 32;
	public int height = 32;
	public static Cell[,] cells;
	public GameObject gridParent;
	public GameObject CellPrefab;

	public void init()
	{
		cells = new Cell[height, width];
		for (int y = 0; y < height; y++) {
			for (int x = 0; x < width; x++) {
				GameObject cell = GameObject.Instantiate<GameObject> (CellPrefab);
				cell.name = "(" + x + ", " + y + ")";
				cell.transform.SetParent (gridParent.transform);
				cells [y, x] = cell.GetComponent<Cell> ();
				cells [y, x].pos = new Vector2 (x, y);
				cells [y, x].QText = cells [y, x].GetComponentsInChildren<Text> () [0];
				cells [y, x].valueText = cells [y, x].GetComponentsInChildren<Text> () [1];
			}
		}
	}

	public static Cell getcell (int posx , int posy){
		return cells[posy , posx];
	}

	public static void setPermission(int x, int y, int player)
	{
		Grid.getcell (x, y).Permission [player] = true;
		if (x < 31)
			Grid.getcell (x + 1, y).Permission [player] = true;
		if (x > 0)
			Grid.getcell (x - 1, y).Permission [player] = true;
		if (y < 31)
			Grid.getcell (x, y + 1).Permission [player] = true;
		if (y > 0)
			Grid.getcell (x, y - 1).Permission [player] = true;
	}
	public static void setFirstcell (int x, int y , Player player)
	{
		for(int i = 0;i < 5;i++)
			Grid.cells [x, y].increment ();
		Grid.setPermission (y, x, player.flag.playerNum);
	}
}
