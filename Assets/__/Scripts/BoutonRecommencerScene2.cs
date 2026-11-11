using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRecommencerScene2 : MonoBehaviour
{
    public string nomDeLaScene = "Niveau 2"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Niveau 2");
    }
}

