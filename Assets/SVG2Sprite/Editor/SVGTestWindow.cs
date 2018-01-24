using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class SVGTestWindow : EditorWindow {
	[MenuItem("Window/SVGTest")]
	static void Create() {
		var win = (SVGTestWindow)EditorWindow.GetWindow(typeof(SVGTestWindow));
		win.Show();
	}
	TextAsset _svgFile;
	void OnGUI() {
		_svgFile = (TextAsset)EditorGUILayout.ObjectField("SVG File", _svgFile, typeof(TextAsset), false);

		if (_svgFile != null && GUILayout.Button("SVG - OK")) {
			Debug.Log("Parse");
			var svgdoc = new SVGDocument(_svgFile.text, null);
			//DumpISVGDrawable(svgdoc.RootElement);
			Debug.Log(svgdoc);
		}
	}
	//void DumpISVGDrawable(ISVGDrawable element) {
	//	Debug.Log(typeof(element));
	//	foreach (var e in element._
	//}
}
















