using UnityEngine;
using UnityEditor;

public class Delete : EditorWindow
{
    [MenuItem("Window/NewTools/Destroy")]
    public static void ShowWindow()
    {
        GetWindow<Delete>("Destroy");
    }

    void OnGUI()
    {
        GUILayout.Label("Delete the selected objects!", EditorStyles.boldLabel);


        if (GUILayout.Button("Destroy!"))
        {
            Destroyer();
        }

    }

    void Destroyer()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            if (obj != null)
            {
                DestroyImmediate(obj);
            }
        }
    }
}
