using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int curHP; // Current HP
    public int maxHP;
    public int scoreToGive;

    [Header("Movement")]
    public float moveSpeed;
    public float atkRange;

    public float yPathOffset; // Ground detection

    private List<Vector3> path;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        curHP = maxHP;
        target = FindObjectOfType<PlayerController>().gameObject;

        // Which function to run, , interval delay
        InvokeRepeating("UpdatePath", 0.0f, 0.5f); // Loop that has pauses
    
    }

    void UpdatePath()
    {
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position,target.transform.position,NavMesh.AllAreas,navMeshPath);
        // Save path as a list
        path = navMeshPath.corners.ToList();
    }

    void ChaseTarget()
    {
        if (path.Count == 0)
        {
            return;
        }
        // Move toward target path
        transform.position = Vector3.MoveTowards(
             transform.position,
             path[0] + new Vector3(0, yPathOffset, 0),
             moveSpeed * Time.deltaTime);
        
        if(transform.position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }

    public void TakeDamage()
    {
        curHP -= 0;//damage;
        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
    }
        

    // Update is called once per frame
    void Update()
    {
        // Look at target
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x,dir.y) * Mathf.Rad2Deg;

        transform.eulerAngles = Vector3.up * angle;

        // Get distance between enemy and target
        float dist = Vector3.Distance(transform.position, target.transform.position);

        if(dist <= atkRange)
        {
            // Attack
        }
        else
        {
            ChaseTarget();
        }
    }
}
