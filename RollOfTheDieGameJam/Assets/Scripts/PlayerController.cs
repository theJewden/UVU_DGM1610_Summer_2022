using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rig; // Declare our ridgid body
   // public Text collectedText;
    public static int collectedAmount;
    public GameObject arrowPrefab;
    public float arrowSpeed;
    public float arrowFireDelay;
    private float arrowLastFire;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();  //Pull our ridgidbody from unity and put it into our var
    }

    // Update is called once per frame
    void Update()
    {
        arrowFireDelay = GameController.FireRate;
        speed = GameController.MoveSpeed;
        
        // Get our input on the keyboard
        float horiMov = Input.GetAxis("Horizontal");
        float vertMov = Input.GetAxis("Vertical");

        float horiShoot = Input.GetAxis("ShootHorizontal");
        float vertShoot = Input.GetAxis("ShootVertical");

        if ((horiShoot != 0 || vertShoot != 0) && Time.time > arrowLastFire + arrowFireDelay)
        {
            Shoot(horiShoot, vertShoot);
            arrowLastFire = Time.time;
        }

        rig.velocity = new Vector3((horiMov * speed), (vertMov * speed), 0); // Move our player with input

       // collectedText.text = "Collected Amount: " + collectedAmount; // Keep track of items collected

    }

    void Shoot(float x, float y)
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject;
        arrow.AddComponent<Rigidbody2D>().gravityScale = 0;
        arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) * arrowSpeed : Mathf.Ceil(x) * arrowSpeed,
            (y < 0) ? Mathf.Floor(y) * arrowSpeed : Mathf.Ceil(y) * arrowSpeed,
            0);
    }
}
