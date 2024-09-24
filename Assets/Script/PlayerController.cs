using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }
    void Update()
    {
        //Move Player
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * speed * Time.deltaTime * hInput);
        transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

        //Firing the Projectile of Doom

        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
