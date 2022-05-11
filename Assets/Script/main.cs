using UnityEngine;
public class main : MonoBehaviour
{
    public float spin_speed = 100;
    private float rotate_y;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rotate_y += (spin_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rotate_y -= (spin_speed * Time.deltaTime);
        }
        rotate_y = rotate_y % 360.0f;
        this.transform.rotation = Quaternion.Euler(90, rotate_y, 0);
    }
}