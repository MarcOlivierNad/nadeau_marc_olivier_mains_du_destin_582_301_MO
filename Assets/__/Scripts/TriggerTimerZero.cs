using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimerZero : MonoBehaviour
{
    public string nomDeLaScene = "Game Over"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Game Over");
    }
}

