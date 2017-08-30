using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignQ{

	//public AssignQ aq = this;
	public static int sizeQ;
	private static Queue<Vector2> queue = new Queue<Vector2>();
	public static Vector2 Get()
	{
		return queue.Dequeue ();
	}

	public static void Set(Vector2 v)
	{
		queue.Enqueue (v);
	}
}
