using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StarshipController))]
public class FieldOfViewEditor : Editor
{
    void OnSceneGUI()
    {
        StarshipController fow = (StarshipController)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360,  3);
    }
}
