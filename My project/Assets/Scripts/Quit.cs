using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        };
    }
}