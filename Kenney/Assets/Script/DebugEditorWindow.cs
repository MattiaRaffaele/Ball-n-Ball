using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugEditorWindow : EditorWindow
{
    bool turnOffAnimations;
    string tag;
    int i;



    [MenuItem("Tools/DebugManager")]
    public static void ShowWindow()
    {
        GetWindow<DebugEditorWindow>("DebugManager");
    }

    private void OnGUI()
    {

        GUILayout.Label("Debug options\n" , EditorStyles.boldLabel);
        turnOffAnimations = EditorGUILayout.Toggle("DisableAllAnimations", turnOffAnimations);

        GUILayout.Space(20);
        GUILayout.Label("Target");
        tag = EditorGUILayout.TextField("Tag", tag);


        if (GUILayout.Button("Save Changes"))
        {
            SaveChanges(tag);
        }


        GUILayout.Space(10);
        GUILayout.Label("Alpha 1.0 - ELMETIU", EditorStyles.miniLabel);
    }

    private void SaveChanges(string tagString)
    {
        if (turnOffAnimations)
        {
            try
            {
                GameObject[] Enemies = GameObject.FindGameObjectsWithTag(tag);
                for (i = 0; i < 100; i++)
                {
                    Enemies[i].GetComponent<Animator>().enabled = false;
                    Enemies[i].GetComponentInChildren<Animator>().enabled = false;

                    Debug.LogWarning("All animations are currently disabled");
                }
            }
            catch (ArgumentException)
            {
                Debug.LogError("ERR:001 - Cannot continue if you dont insert a tag");
            }
            catch (UnityException)
            {
                Debug.LogError("ERR:002 - " + "'" + tagString + '"' + " is not a valid tag");
            }
        }
    }
}
