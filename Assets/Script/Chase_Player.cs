using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ChasePlayer : MonoBehaviour
{
    public Transform player;  // Référence au joueur
    private NavMeshAgent navMeshAgent;

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
        if (collision.tag == "Player")
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}





