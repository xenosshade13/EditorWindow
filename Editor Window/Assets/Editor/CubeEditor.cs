using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SerializedProperty cubeStatsSP = serializedObject.FindProperty("cube");
        if(cubeStatsSP.objectReferenceValue == null)
        {
            EditorGUILayout.PropertyField(cubeStatsSP);
        }
        else
        {
            CubeStats cube = cubeStatsSP.objectReferenceValue as CubeStats;

            EditorGUILayout.LabelField(cube.displayName + "Stats");
            EditorGUILayout.PropertyField(cubeStatsSP);
            EditorGUILayout.Space();
            cube.strength = EditorGUILayout.IntField("Strength: ", cube.strength);
            cube.body = EditorGUILayout.IntField("Body: ", cube.body);
            cube.will = EditorGUILayout.IntField("Will: ", cube.will);
            EditorGUILayout.Space();
            int health = ((cube.strength + cube.body + cube.will) / 3) * 4;
            int mana = ((cube.body + cube.will) / 3) * 2;
            int charisma = ((cube.body + cube.strength) + health) / 3;
            EditorGUILayout.LabelField("Calculated Stats: ");
            EditorGUILayout.LabelField("Health: " + health);
            EditorGUILayout.LabelField("Mana: " + mana);
            EditorGUILayout.LabelField("Charisma: " + charisma);
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Stats: ");
            SerializedProperty stat = serializedObject.FindProperty("stat");
            stat.stringValue = EditorGUILayout.TextField("Stat ", stat.stringValue);
        }
        serializedObject.ApplyModifiedProperties();
    }
}
