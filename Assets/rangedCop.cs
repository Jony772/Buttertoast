using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class rangedCop : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;


    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float timeBetweenAttacks;
    bool alreadyAttacked; 

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GaneObject.Find("ButterGame").transform;
        agent = GetComponent<NavMeshAgent>();

    }


    void Update()
    {
        playerInSightRange = physics.CheckSphere(Transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = physics.CheckSphere(Transform.position, attackRange, whatIsPlayer);


        if(!playerInSightRange && !playerInAttackRange) Patroling();
        if(playerInSightRange && !playerInAttackRange) ChasePlayer();
        if(playerInAttackRange && playerInSightRange) AttackPlayer();
    }


    private void Patroling()
    {
        if(!walkPointSet) searchWalkPoint();
        if(walkPointSet)
            agent.SetDestination(walkPoint);
        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        if(distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }

    private void searchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3 (transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if(physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }


    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if(!alreadyAttacked)
        {
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
            Debug.Log("cop Attack");
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }





    void Start()
    {
        
    }


}
