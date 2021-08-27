using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class rangedCop : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    public GameObject bullet;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float timeBetweenAttacks;
    bool alreadyAttacked; 
    public GameObject go;
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;


    public Animator anim;

    private void Awake()
    {
        player = GameObject.Find("ButterGame").transform;
        agent = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();

    }


    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);


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
        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
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
            anim.SetBool("isShooting", true);
            //Quaternion rot = Quaternion.Euler(5.652f,0.651f, -37.101f);
            //Instantiate(bullet, new Vector3(0.178f, 1.368f, 0.906f), Quaternion.identity);
             //GameObject go = Instantiate(bullet, new Vector3 (0.178f,1.368f,0.906f), rot) as GameObject; 
            // go.transform.parent = GameObject.Find("Cop").transform;
            bullet.SetActive(true);
            Debug.Log("cop Attack");
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
        anim.SetBool("isShooting", false);
        bullet.SetActive(false);

        //anim.SetBool("isShooting", false);

    }









    void Start()
    {
        
    }


}
