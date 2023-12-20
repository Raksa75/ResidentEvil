using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activer l'UI "Game Over"
            gameOverUI.SetActive(true);
            // Vous pouvez également ajouter d'autres actions ici, comme arrêter le temps, désactiver le joueur, etc.
        }
    }
}
