using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

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

	public static string CreateJSONTemplate()
	{
		TileDef template = new TileDef("TemplateID", "TileDefTemplate", "", "", new List<ActionDef>());
		return JsonConvert.SerializeObject(template);
	}
#endregion JSONSerializable

}
