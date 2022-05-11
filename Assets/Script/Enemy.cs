using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stopping;
    public float retrit;
    private  Transform player;


    private float timeBTW;
    public float startBTW;
    public GameObject proj;

    private void Start()
    {
      player=GameObject.FindGameObjectWithTag("Player").transform;

        timeBTW = startBTW;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position,player.position)>stopping)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) > stopping&& (Vector2.Distance(transform.position, player.position) > retrit))
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retrit)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        if (timeBTW<=0)
        {
            Instantiate(proj,transform.position,Quaternion.identity);
            timeBTW = startBTW;
        }
        else
        {
            timeBTW -= Time.deltaTime;
        }
    }
}

