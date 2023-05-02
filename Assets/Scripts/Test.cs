using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hello");
        Debug.Log("goodbye");
    }

    private void Show(string message)
    {
        Debug.Log($"{message}");
    }
}
