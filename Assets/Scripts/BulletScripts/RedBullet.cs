 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RedBullet : MonoBehaviour
{
    public Plane plane;

    public float speed;

    private Rigidbody2D myBody;

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(0f, -speed);
    }


    void Start()
    {
        plane = GameObject.FindGameObjectWithTag("Player").GetComponent<Plane>();
    }

    //Hàm bắt sự kiện va chạm

    void OnTriggerEnter2D(Collider2D target)
    {
        Vector3 temp = transform.position;
        if (target.CompareTag("Player"))
        {
            plane.Damage(1);
            //Destroy(target.gameObject);
            
        }

        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
