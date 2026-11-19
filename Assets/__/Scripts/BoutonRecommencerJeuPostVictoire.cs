using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRecommencerJeuPostVictoire: MonoBehaviour
{
    public string nomDeLaScene = "Menu principal"; // Nom exact ☝️


    public void ChangeScene()
    {
        SceneManager.LoadScene("Menu principal");
    }
}

