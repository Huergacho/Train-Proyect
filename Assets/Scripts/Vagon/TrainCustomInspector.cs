using UnityEditor;
using UnityEngine;
[CustomEditor(typeof (TrainController))]
public class TrainCustomInspector : Editor
{ 
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        TrainController train = (TrainController)target;
        if (GUILayout.Button("AddVagon"))
        {
            train.AddVagon();
        }
        if (GUILayout.Button("RemoveVagon"))
        {
            train.RemoveVagon();
        }
    }
}