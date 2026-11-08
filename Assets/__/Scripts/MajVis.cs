using UnityEngine;
using TMPro;

public class MajVis : MonoBehaviour
{
    [SerializeField] private TMP_Text NombreVis;
    [SerializeField] private string message = "You found it!";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NombreVis.text = "4/8";
        }
    }
}