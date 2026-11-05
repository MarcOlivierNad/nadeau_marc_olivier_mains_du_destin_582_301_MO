using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonCommencer : MonoBehaviour
{
    public string nomDeLaScene = "Niveau 1"; // Nom exact ☝️


    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}

