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
        treeView.searchString = EditorGUILayout.TextField("Search", treeView.searchString);
        var lastRect = GUILayoutUtility.GetLastRect();
        treeView.OnGUI(new Rect(0, lastRect.yMax, position.width, position.height));
    }
}
