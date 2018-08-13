using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.IMGUI.Controls;

public class StudyTreeWindow : EditorWindow {
    [MenuItem("Tool/StudyTreeWindow")]
    public static void Open()
    {
        GetWindow<StudyTreeWindow>();
    }

    TreeViewState state;
    StudyTreeView treeView;

    void OnEnable()
    {
        state = new TreeViewState();
        treeView = new StudyTreeView(state);
        treeView.Reload();
    }

    void OnGUI()
    {
        treeView.searchString = DrawSearchGUI("Search", treeView.searchString);
        var lastRect = GUILayoutUtility.GetLastRect();
        treeView.OnGUI(new Rect(0, lastRect.yMax, position.width, position.height));
    }

    string DrawSearchGUI(string label, string text)
    {
        using(new EditorGUILayout.HorizontalScope())
        {
            EditorGUILayout.LabelField(label, GUILayout.Width(50));
            GUI.SetNextControlName("SearchControl");
            text = GUILayout.TextField(text, "SearchTextField", GUILayout.Width(120));
            if(string.IsNullOrEmpty(text))
            {
                GUILayout.Button("", "SearchCancelButtonEmpty");
            } else {
                if(GUILayout.Button("", "SearchCancelButton"))
                {
                    text = string.Empty;
                }
            }
        }
        return text;
    }
}
