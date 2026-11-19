using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimerZeroScene2 : MonoBehaviour
{
    public string nomDeLaScene = "Game Over Scène 2"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Game Over Scène 2");
    }
}

