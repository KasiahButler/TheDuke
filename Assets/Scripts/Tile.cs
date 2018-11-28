using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
	private string defId;
	private TileDef def;

	public string Name { get { return def.DisplayName; } }
}
