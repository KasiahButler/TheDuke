using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
	public Vector2 gridPosition { get; private set; }
	public Tile containedTile { get; private set; }
	bool isOccupied { get { return containedTile != null; } }

	Image abilityIcon;
	// Gonna use this when we mouse over a Node so that it will light up...
	// ...or when we want to highlight possible moves
	public void Highlight(Color highlight) { }

	public void SetGridPosition(Vector2 newPosition)
	{
		gridPosition = newPosition;
	}

	public void PlaceTile(Tile newTile)
	{
		containedTile = newTile;
	}
}
