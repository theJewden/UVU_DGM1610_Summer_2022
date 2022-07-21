using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContro : MonoBehaviour
{
    public enum EnemyState
    {
        Wander,

        Follow,

        Die,

        Attack,

        Wait
    };

    public enum EnemyType
    {
        Melee,

        Ranged
    };

    GameObject player;
    public GameObject room;
    public GameObject bulletPrefab;
    public EnemyState currState = EnemyState.Wander;
    public EnemyType enemyType = EnemyType.Melee;
    public float range;
    public float attackRange;
    public float speed;
    public float coolDown;
    public float localEnemyBulletSize = .35f;
    private bool chooseDir = false;
    private bool dead = false;
    private bool coolDownAttack = false;
    private Vector3 randomDir;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        // Set up the states of the Enemy
        switch(currState)
        {
            case (EnemyState.Wander):
                Wander();
                break;
            case (EnemyState.Follow):
                Follow();
                break;
            case (EnemyState.Die):
                Die();
                break;
            case(EnemyState.Attack):
                Attack();
                break;
            case (EnemyState.Wait):
                Wait();
                break;
        }


        // Switch state if player is in range or not in range 
        if (room.GetComponent<Room>().isPlayerInRoom == true)
        {
            if (IsPlayerInRange(range) && currState != EnemyState.Die)
            {
                currState = EnemyState.Follow;

            }
            else if (!IsPlayerInRange(range) && currState != EnemyState.Die)
            {
                currState = EnemyState.Wander;
            }


            if (Vector3.Distance(transform.position, player.transform.position) < attackRange)
            {
                currState = EnemyState.Attack;
            }
        } else
        {
            currState = EnemyState.Wait;
        }
       
    }


    // Check range between enemy and player
    private bool IsPlayerInRange(float range)
    {
        return Vector3.Distance(transform.position, player.transform.position) <= range;
    }

    private IEnumerator ChooseDirection()
    {
        chooseDir = true;
        yield return new WaitForSeconds(Random.Range(2f,8f)); // Random time until the enemy moves a different direction
        randomDir = new Vector3(0, 0, Random.Range(0, 360)); // Give a random direction for the enemy to move in
        Quaternion nextRotation = Quaternion.Euler(randomDir); // Use our randomDir to give us a random rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, nextRotation, Random.Range(0.0f, 2.5f));
        chooseDir = false;

    }

    void Wander()
    {
        if(!chooseDir)
        {
            StartCoroutine(ChooseDirection());
        }

        transform.position += -transform.right * speed * Time.deltaTime;
        if(IsPlayerInRange(range))
        {
            currState = EnemyState.Follow;
        }
    }

    void Follow()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); // Have the enemy move towards the player
    }
    void Wait()
    {
        //Do nothing
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    void Attack()
    {
        if(!coolDownAttack)
        {
            switch(enemyType) {
                case(EnemyType.Melee):
                    GameController.DamagePlayer(.5f);
                    StartCoroutine(CoolDown());
                    break;
                case(EnemyType.Ranged):
                    GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
                    bullet.GetComponent<BulletController>().GetPlayer(player.transform);
                    bullet.AddComponent<Rigidbody2D>().gravityScale = 0;
                    bullet.GetComponent<BulletController>().isEnemyBullet = true;
                    bullet.GetComponent<BulletController>().enemyBulletSize = localEnemyBulletSize;
                    StartCoroutine(CoolDown());
                    break;
            }
        }
        
    }

    private IEnumerator CoolDown()
    {
        coolDownAttack = true;
        yield return new WaitForSeconds(coolDown);
        coolDownAttack = false;
    }
}
