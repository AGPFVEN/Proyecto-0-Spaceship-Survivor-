using UnityEngine;
using System.Collections;
using UnityEditor;

//[CustomEditor(typeof(EnemyController))]
//public class FieldOfViewEditor : Editor
//{

//    void OnSceneGUI()
//    {
//        EnemyController fow = (EnemyController)target;
//        Handles.color = Color.white;
//        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.left, 360, fow.viewRadius);
//        Vector3 viewAngleA = fow.DirFromAngle(-fow.viewAngle / 2, false);
//        Vector3 viewAngleB = fow.DirFromAngle(fow.viewAngle / 2, false);

//        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleA * fow.viewRadius);
//        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleB * fow.viewRadius);

//    }
//}
