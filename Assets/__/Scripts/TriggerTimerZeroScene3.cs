using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimerZeroScene3 : MonoBehaviour
{
    public string nomDeLaScene = "Game Over Scène 3"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Game Over Scène 3");
    }
}

