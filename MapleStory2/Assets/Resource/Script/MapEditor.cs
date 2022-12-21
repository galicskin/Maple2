using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace GHJ_Lib
{
	
	public class MapEditor: EditorWindow
	{
		List<GameObject> Prefabs;


		[MenuItem("Tools/My Map Editor")]
		public static void ShowEditor()
		{
			EditorWindow wnd = GetWindow<MapEditor>();
			wnd.titleContent = new GUIContent("Map Editor");
		}

		public void CreateGUI()
		{
			Prefabs = new List<GameObject>();
			rootVisualElement.Add(new Label("Hello"));
			
		}
	}
}