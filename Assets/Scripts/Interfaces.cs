using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface JSONSerializable
{
	string ToJSON();
	object FromJSON(string JSON);
	string CreateJSONTemplate();
}
