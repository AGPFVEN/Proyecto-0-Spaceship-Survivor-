using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(EnemyController))]
public class FieldOfViewEditor : Editor
{

    void OnSceneGUI()
    {
        EnemyController fow = (EnemyController)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360, fow.viewRadius);

    }
}
