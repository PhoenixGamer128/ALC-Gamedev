using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDistance;

    private Transform target;

    private float shotDelay;
    public float shootDelay;
    public GameObject projectile;

    private float _distance;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = shootDelay;
    }

    // Update is called once per frame
    void Update()
    {
        
        _distance = Vector2.Distance(transform.position,target.position);
        if(_distance > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        }
        else if(_distance < retreatDistance)
        {
            transform.position = (Vector2.MoveTowards(transform.position,target.position,-speed*Time.deltaTime));
        }

        if(shotDelay <= 0)
        {
            Attack();
        }
        else if(shotDelay > 0)
        {
            shotDelay -= Time.deltaTime;
        }
    }

    void Attack()
    {
        if(_distance >= stopDistance)
        {
            transform.position = this.transform.position; // ???
            Instantiate(projectile,transform.position,Quaternion.identity); // Fire Projectile
            shotDelay = shootDelay;
        }
    }
}
