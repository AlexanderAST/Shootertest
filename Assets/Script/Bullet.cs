
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Speed=0;

    
    void Start()
    { 
        if (bulletRigidBody == null)
        {
            bulletRigidBody = GetComponent<Rigidbody>();
        }



        bulletRigidBody.velocity = transform.forward * bulletSpeed;
    }

    void Update()
    {
        transform.Translate(Vector3.forward*Speed*Time.deltaTime);
        
    }
    public int bulletSpeed;
    Rigidbody bulletRigidBody;


    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
           
            transform.forward = Vector3.Reflect(collision.contacts[0].point, collision.contacts[0].normal);



           
            bulletRigidBody.velocity = transform.forward * bulletSpeed;
        }



    }

    
}
