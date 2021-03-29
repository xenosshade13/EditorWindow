using UnityEngine;
using UnityEditor;

public class Toast : EditorWindow
{
    public GameObject ToastPrefab;
    public GameObject Toaster;
    public float toastEaten = 1;

    [MenuItem("Window/NewTools/Toast")]
    public static void ShowWindow()
    {
        GetWindow<Toast>("Toast");
    }

    void OnGUI()
    {
        GUILayout.Label("The Levels of Toasty are high!", EditorStyles.boldLabel);

        if (GUILayout.Button("Toasty"))
        {
            Toastier();
        }
    }

    void Toastier()
    {
        Toaster = GameObject.FindWithTag("Toaster");

        Instantiate(ToastPrefab, Toaster.transform.position, Toaster.transform.rotation)
            as GameObject;
    }
}
