using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChasePlayer : MonoBehaviour
{
    public Transform player;  // Référence au joueur
    private NavMeshAgent navMeshAgent;
    public GameObject gameOverUI;
    public Button restartButton;

    void Start()
    {
        // Récupérez le composant NavMeshAgent
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (player == null)
        {
            // Si la référence au joueur n'est pas définie, recherchez-le dans la scène
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        // Déplacez l'IA vers la position du joueur
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        // Gérez la collision avec le joueur
        if (collision.tag == "Player")
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

    void RestartLevel()
    {
    //    SceneManager.LoadScene("SampleScene");
        // À remplacer par votre logique de redémarrage de niveau
        // Par exemple, rechargez la scène ou réinitialisez la position du joueur et de l'IA
        Debug.Log("Level Restarted");
   //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
