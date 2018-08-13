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
        var root = new TreeViewItem(id:1, depth:-1,displayName:"Root");
        var parent = new TreeViewItem(id:2, depth:0, displayName:"Parent1");
        root.children = new List<TreeViewItem>
        {
            parent,
            new TreeViewItem(id:3, depth:0, displayName:"Parent2"),
        };
        parent.children = new List<TreeViewItem>
        {
            new TreeViewItem(id:4, depth:1, displayName:"child"),
        };
        return root;
    }
}
