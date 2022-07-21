using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float lifeTime;
    public bool isEnemyBullet = false;
    public float enemyDamage = .5f;
    public float enemyBulletSize = .35f;

    private Vector2 lastPos;
    private Vector2 currPos;
    private Vector2 playerPos;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathDelay());
        if(!isEnemyBullet)
        {
            transform.localScale = new Vector2(GameController.BulletSize, GameController.BulletSize);
        } else if (isEnemyBullet)
        {
            transform.localScale = new Vector2(enemyBulletSize, enemyBulletSize);
        }

    }

    void Update()
    {
        if(isEnemyBullet)
        {
            currPos = transform.position;
            transform.position = Vector2.MoveTowards(transform.position, playerPos, 5f * Time.deltaTime);
            if(currPos == lastPos)
            {
                Destroy(gameObject);
            }
            lastPos = currPos;
        }
    }

    public void GetPlayer(Transform player)
    {
        playerPos = player.position;
    }

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" && !isEnemyBullet )
        {
            col.gameObject.GetComponent<EnemyContro>().Die();
            Destroy(gameObject);
        }

        if(col.tag == "Player" && isEnemyBullet)
        {
            GameController.DamagePlayer(enemyDamage);
            Destroy(gameObject);
        }
    }
}
