using JetBrains.Annotations;
using System.Reflection.Metadata.Ecma335;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    [SerializeField] public float niveauDetection = 0;
    [SerializeField] public float niveauDetectionSeuil = 3;
    [SerializeField] public string charger = "Game Over";





    void Start()
    {



    }



    // Update is called once per frame
    void Update()
    {

        if (niveauDetection == niveauDetectionSeuil)
        {
            SceneManager.LoadSceneAsync("Game Over");

        }
        return;
    }
}

 
        





