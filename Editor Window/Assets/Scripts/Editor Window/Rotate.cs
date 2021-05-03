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
       foreach(GameObject obj in Selection.gameObjects)
    {
      Transform objTransf = obj.GetComponent<Transform>();
      objTransf.Rotate(0f, 100f, 0f);
    }
    }
}
