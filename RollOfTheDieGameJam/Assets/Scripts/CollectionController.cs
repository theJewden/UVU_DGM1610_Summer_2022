using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public string name;
    public string description;
    public Sprite itemImage;
}

public class CollectionController : MonoBehaviour
{
    public Item item;
    public float healthChange;
    public float moveSpeedChange;
    public float attackSpeedChange;
    public float bulletSizeChange;




    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = item.itemImage;
        Destroy(GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerController.collectedAmount += 1;
            GameController.HealPlayer(healthChange);
            GameController.ChangeMoveSpeed(moveSpeedChange);
            GameController.ChangeFireRate(attackSpeedChange);
            GameController.ChangeBulletSize(bulletSizeChange);
            Destroy(gameObject);
        }
    }
}
