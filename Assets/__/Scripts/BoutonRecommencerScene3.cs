using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRecommencerScene3 : MonoBehaviour
{
    public string nomDeLaScene = "Niveau 3"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Niveau 3");
    }
}

