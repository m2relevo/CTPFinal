using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEditor;
using System;

[CustomEditor(typeof(WeaponGenerator))]
public class GUIOverrideWeaponGenerator : Editor
{
        string[] modelTypeOptions = new[] { "Sword", "Gun" };
        int modelTypeOptionsIndex = 0;

    public override void OnInspectorGUI()
    {
        WeaponGenerator targetScript = (WeaponGenerator)target;

        EditorGUILayout.HelpBox("Please choose either Sword or Gun type",MessageType.Info, true);
        modelTypeOptionsIndex = Array.IndexOf(modelTypeOptions, targetScript.ModelType);
        modelTypeOptionsIndex = EditorGUILayout.Popup(modelTypeOptionsIndex, modelTypeOptions);
        targetScript.ModelType = modelTypeOptions[modelTypeOptionsIndex];

        targetScript.WeaponSpawnLocation = (GameObject)EditorGUILayout.ObjectField("Weapon Spawn Location", targetScript.WeaponSpawnLocation, typeof(GameObject), true);

        if (targetScript.ModelType == "Sword" && targetScript.WeaponSpawnLocation != null)
        {
            EditorGUILayout.HelpBox("Enabling Custom will enable custom pivot placement", MessageType.Info, true);
            targetScript.CustomSword = EditorGUILayout.Toggle("Enable Custom Sword Layout?", targetScript.CustomSword);
            targetScript.SourceSword = (GameObject)EditorGUILayout.ObjectField("Base Model", targetScript.SourceSword, typeof(GameObject), true);

            if (targetScript.SourceSword != null)
            {
                EditorGUILayout.HelpBox("Place individual model gameobjects into the fields. Increasing the list value allows for further fields to be filled", MessageType.Info, true);
                EditorGUILayout.HelpBox("All intentional empty fields must be filled with EmptyGameObject", MessageType.Warning, true);
                serializedObject.Update();
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListBlade"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListGuard"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListHilt"), true);

                serializedObject.ApplyModifiedProperties();

                if (targetScript.CustomSword == true)
                {
                    targetScript.SourceBlade = (GameObject)EditorGUILayout.ObjectField("Blade Pivot Point", targetScript.SourceBlade, typeof(GameObject), true);
                    if (targetScript.SourceBlade == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceGuard = (GameObject)EditorGUILayout.ObjectField("Guard Pivot Point", targetScript.SourceGuard, typeof(GameObject), true);
                    if (targetScript.SourceGuard == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceHilt = (GameObject)EditorGUILayout.ObjectField("Hilt Pivot Point", targetScript.SourceHilt, typeof(GameObject), true);
                    if (targetScript.SourceHilt == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                }
            }
        }

        if (targetScript.ModelType == "Gun" && targetScript.WeaponSpawnLocation != null)
        {
            EditorGUILayout.HelpBox("Enabling Custom will enable custom pivot placement", MessageType.Info, true);
            targetScript.CustomGun = EditorGUILayout.Toggle("Enable Custom Gun Layout?", targetScript.CustomGun);
            targetScript.SourceGun = (GameObject)EditorGUILayout.ObjectField("Base Model", targetScript.SourceGun, typeof(GameObject), true);

            if (targetScript.SourceGun != null)
            {
                EditorGUILayout.HelpBox("Place individual model gameobjects into the fields. Increasing the list value allows for further fields to be filled", MessageType.Info, true);
                EditorGUILayout.HelpBox("All intentional empty fields must be filled with EmptyGameObject", MessageType.Warning, true);
                serializedObject.Update();
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListMag"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListScope"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListBarrelExt"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListSideMount"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ListUnderMount"), true);
                serializedObject.ApplyModifiedProperties();

                if (targetScript.CustomGun == true)
                {
                    targetScript.SourceMag = (GameObject)EditorGUILayout.ObjectField("Magazine Pivot Point", targetScript.SourceMag, typeof(GameObject), true);
                    if (targetScript.SourceMag == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceScope = (GameObject)EditorGUILayout.ObjectField("Scope Pivot Point", targetScript.SourceScope, typeof(GameObject), true);
                    if (targetScript.SourceScope == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceSideMount = (GameObject)EditorGUILayout.ObjectField("SideMount Pivot Point", targetScript.SourceSideMount, typeof(GameObject), true);
                    if (targetScript.SourceSideMount == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceUnderMount = (GameObject)EditorGUILayout.ObjectField("UnderMount Pivot Point", targetScript.SourceUnderMount, typeof(GameObject), true);
                    if (targetScript.SourceUnderMount == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                    targetScript.SourceBarrelExt = (GameObject)EditorGUILayout.ObjectField("Barrel Ext' Pivot Point", targetScript.SourceBarrelExt, typeof(GameObject), true);
                    if (targetScript.SourceBarrelExt == null)
                    {
                        EditorGUILayout.HelpBox("All intentional empty GameObject fields must be filled with EmptyLocation from the scene", MessageType.Warning, true);
                    }
                }
            }
        }
        //base.OnInspectorGUI();
    }
}
