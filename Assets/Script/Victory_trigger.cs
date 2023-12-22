using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSceneTrigger : MonoBehaviour
{
    // Définir le nom de la scène à recharger (modifiable en fonction de votre projet)
    public string sceneToReload = "NomDeVotreScene";

    private void OnTriggerEnter(Collider other)
    {
        // Vérifier si le déclencheur entre en collision avec un objet portant le tag "Player"
        if (other.CompareTag("Player"))
        {
            // Recharger la scène
            SceneManager.LoadScene(sceneToReload);
        }
    }
}
