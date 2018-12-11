using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public enum ActionType
{
	INVALID = 0,
	Move = 1,
	Jump = 2,
	Slide = 3,
	Jumpslide = 4,
	Strike = 5,
	Command = 6
}

public class ActionDef
{
	public ActionType type { get; private set; }

	public Vector2 target { get; private set; }

	public ActionDef() { }

	public ActionDef(ActionType type, Vector2 target)
	{
		this.type = type;
		this.target = target;
	}
}

public class TileDef : JSONSerializable
{
	public string ID { get; private set; }
	public string DisplayName { get; private set; }
	public string PrefabID { get; private set; }

	public string AbilityID { get; private set; }
	public List<ActionDef> Actions { get; private set; }

	public TileDef()
	{

	}

	public TileDef(string id, string name, string prefabID, string abilityID, List<ActionDef> actions)
	{
		this.ID = id;
		this.DisplayName = name;
		this.PrefabID = prefabID;
		this.AbilityID = abilityID;
		this.Actions = actions;
	}

#region JSONSerializable
	public string ToJSON()
	{
		return JsonConvert.SerializeObject(this);
	}

	public object FromJSON(string JSON)
	{
		return JsonConvert.DeserializeObject<TileDef>(JSON);
	}
#endregion JSONSerializable

}
