using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletPref;
    public Transform Pivot;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(BulletPref, Pivot.position, Pivot.rotation);
        }
    }
}
