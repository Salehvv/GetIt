using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
	public Flag currentFlag;
	public Vector2 pos;
	public int numberOfSoldiers;
	public Text QText;
	public Text valueText;
	public bool[] Permission = new bool[8];
	public void onClick()
	{
		InputManager.cellClick (this);
	}

	public void increment()
	{
		
		numberOfSoldiers += 1;
		valueText.text = numberOfSoldiers + "";
		GetComponent<Image>().color = GameManager.gm.player.flag.color;
	}
}
