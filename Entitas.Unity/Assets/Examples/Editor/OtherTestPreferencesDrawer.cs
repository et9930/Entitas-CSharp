﻿using Entitas.Unity;
using UnityEditor;

public class OtherTestPreferencesDrawer : IEntitasPreferencesDrawer {

    object _someObject;

    public void Initialize(EntitasPreferencesConfig config) {
        _someObject = new object();
    }

    public void Draw(EntitasPreferencesConfig config) {
        EditorGUILayout.LabelField("Other Test " + _someObject.GetHashCode());
    }
}
