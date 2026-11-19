using UnityEngine;

public class CamLock2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
