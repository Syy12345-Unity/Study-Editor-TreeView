using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StudyTreeWindow : EditorWindow {
    [MenuItem("Tool/StudyTreeWindow")]
    public static void Open()
    {
        GetWindow<StudyTreeWindow>();
    }

    void OnGUI()
    {
        
    }
}
