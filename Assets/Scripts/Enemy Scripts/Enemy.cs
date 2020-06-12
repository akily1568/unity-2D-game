using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;

    private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet; // khai báo biến dành cho viên đạn

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        StartCoroutine(EnemyShoot());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -enemySpeed);
    } 

    IEnumerator EnemyShoot() // hàm có kiểu trả về là 1 coroutine
    {

        yield return new WaitForSeconds(Random.Range(1f, 1f));

        Vector3 temp = transform.position;
        temp.y -= 0.4f;

        Instantiate(bullet, temp, Quaternion.identity); //bắn ra đạn

        StartCoroutine(EnemyShoot());
    }

    //Hàm bắt sự kiện va chạm

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            GamePlayController1.instance.PlaneDiedShowPanel();//truy xuất đến hàm PlanelDiedShowPanel() thông qua instance
        }
        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }
    }

}
