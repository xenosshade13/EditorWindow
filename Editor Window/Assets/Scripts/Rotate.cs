using UnityEngine;
using UnityEditor;

public class MoveLeft : EditorWindow
{
    [MenuItem("Window/NewTools/Rotate")]
    public static void ShowWindow()
    {
        GetWindow<MoveLeft>("Rotate");
    }

    void OnGUI()
    {
        GUILayout.Label("Rotate selected objects!", EditorStyles.boldLabel);

        if (GUILayout.Button("Rotate!"))
        {
            Rotator();
        }
    }

    void Rotator()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            if (obj != null)
            {
                transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
            }
        }
    }
}
