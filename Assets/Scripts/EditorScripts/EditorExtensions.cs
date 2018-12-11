using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

public class EditorExtensions
{
	public const string TileDefDirectory = "JsonTemplates";

	[MenuItem("JSONTemplates/TileDef")]
	public static void GenerateTileDefTemplate()
	{
		// Gotta get our Filepath Combined for where we wanna put this template.
		string fileName = "TileDefTemplate.json";
		string templateDirectory = Path.Combine(TileDefDirectory, fileName);
		string filePath = Path.Combine(Application.dataPath, templateDirectory);

		// Create a meaningful TileDef for the Template
		TileDef template = new TileDef("TileDef_Template", "Template", "Tile_Blank", "TemplateAbility", new List<ActionDef>());
		template.Actions.Add(new ActionDef(ActionType.INVALID, Vector2.zero));

		// Convert the TileDef Template to a JSON String with clean formatting for editing
		string templateJSON = JsonConvert.SerializeObject(template, Formatting.Indented, new StringEnumConverter());

		// Grab a StreamWriter and write the JSON to the filepath we've made
		using (StreamWriter stream = new StreamWriter(filePath))
		{
			stream.Write(templateJSON);
		}

		Debug.Log(string.Format("TileDef Template saved to {0}", filePath));
	}
}
