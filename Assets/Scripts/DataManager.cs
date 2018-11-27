using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceType
{
	Tile = 0,
	TileDef = 1
}

public class DataManager
{
	private Dictionary<string, TileDef> tileDefs;
	private Dictionary<string, Tile> tiles;

	private bool initialized = false;

	public DataManager()
	{
		InitData();
	}

	private void InitData()
	{
		tileDefs = new Dictionary<string, TileDef>();
		tiles = new Dictionary<string, Tile>();
		initialized = true;
	}

	public object Get(ResourceType type, string id)
	{
		if(!initialized)
		{
			return null;
		}

		switch(type)
		{
			case ResourceType.Tile:
				Tile tile;
				tiles.TryGetValue(id, out tile);
				return tile;
			case ResourceType.TileDef:
				TileDef tileDef;
				tileDefs.TryGetValue(id, out tileDef);
				return tileDef;
			default:
				Debug.Log(string.Format("DataManager failed to find {0}", id));
				return null;
		}
	}
}
