using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public Animator zombieAnimator;
    public Transform playerTransform;
    public Transform[] checkpoints;
    public NavMeshAgent enemyAgent;
    private int destPoint = 0;
    private bool playerInView = false;

	void Start ()
    {
        GotoNextPoint(); // start patrolling
	}

    void GotoNextPoint()
    {
        zombieAnimator.SetBool("IsPatrolling", true);
        if (checkpoints.Length == 0)
        {
            return; // error check - returns if no checkpoints set up
        }

        // if on last checkpoint

        enemyAgent.destination = checkpoints[destPoint].position; // choose next checkpoint in array as destination
        destPoint = (destPoint + 1) % checkpoints.Length; // move on to next
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInView = true;
            Debug.Log("Player in view");
            zombieAnimator.SetBool("IsPatrolling", false);
            zombieAnimator.SetBool("IsChasingPlayer", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInView = false;
            Debug.Log("Player leaving view");
            zombieAnimator.SetBool("IsPatrolling", true);
            zombieAnimator.SetBool("IsChasingPlayer", false);
        }
    }

    void Update ()
    {
        if (!playerInView)
        {
            // choose next checkpoint when agent gets close to current one
            if (!enemyAgent.pathPending && enemyAgent.remainingDistance < 0.5f)
            {
                GotoNextPoint();
            }
        }
        else if (playerInView)
        {
            // target the player if player is near enemy, follow path if not
            enemyAgent.destination = playerTransform.position;
        }
    }
}
