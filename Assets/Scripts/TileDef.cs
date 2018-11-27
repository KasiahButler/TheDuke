using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
	Move = 0,
	Jump = 1,
	Slide = 2,
	Jumpslide = 3,
	Strike = 4,
	Command = 5
}

public class ActionDef
{
	public ActionType type { get; private set; }

	public Vector2 target { get; private set; }
}

public class TileDef
{
	public string ID { get; private set; }
	public string DisplayName { get; private set; }
	public string PrefabID { get; private set; }

	public string AbilityID { get; private set; }
	public List<ActionDef> Actions { get; private set; }
}
