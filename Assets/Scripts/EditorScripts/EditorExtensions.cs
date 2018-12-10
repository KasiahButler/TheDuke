using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;
using System.IO;

public class EditorExtensions
{
	public const string TileDefDirectory = "JsonTemplates";

	[MenuItem("JSONTemplates/TileDef")]
	public static void GenerateTileDefTemplate()
	{
		string fileName = "TileDefTemplate.JSON";
		string templateDirectory = Path.Combine(TileDefDirectory, fileName);
		string filePath = Path.Combine(Application.dataPath, templateDirectory);

		TileDef template = new TileDef("TemplateID", "TileDefTemplate", "", "", new List<ActionDef>());
		string templateJSON = JsonConvert.SerializeObject(template, Formatting.Indented);

		using (StreamWriter stream = new StreamWriter(filePath))
		{
			stream.Write(templateJSON);
		}

		Debug.Log(string.Format("TileDef Template saved to {0}", filePath));
	}
}
