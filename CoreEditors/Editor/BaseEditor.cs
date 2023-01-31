using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseEditor : EditorWindow
{
	int value = 0;

	[MenuItem("Animmersion/BaseEditor")]
	public static void ShowWindow()
	{
		GetWindow(typeof(BaseEditor));
	}

	protected void OnGUI()
	{
		if (GUILayout.Button(string.Format("Test Button: {0}", value)))
		{
			value++;
		}
	}
}
