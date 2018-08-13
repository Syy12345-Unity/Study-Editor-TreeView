using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.IMGUI.Controls;

public class StudyTreeView : TreeView {
    public StudyTreeView(TreeViewState state) : base(state)
    {

    }

    protected override TreeViewItem BuildRoot()
    {
        throw new System.NotImplementedException();
    }
}
