using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Plane : MonoBehaviour
{
    public float planeSpeed; // biến tốc độ di chuyển plane

    private Rigidbody2D myBody; //khai báo

    private bool canShoot = true;

    public int ourHearth;
    public int maxHearth = 3;

    [SerializeField]
    private GameObject bullet; // khai báo biến dành cho viên đạn



    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D> (); //khởi tạo 
        ourHearth = maxHearth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlanMovement(); //gọi hàm vật lý khi di chuyển nhân vật


        if (ourHearth <= 0)
        {
        
            Death();
            




        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //kiểm tra, ấn vào phím space bắn viên đạn  
        {
            {
                if (canShoot)//kiểm tra
                {
                    StartCoroutine(Shoot());
                }
                //Instantiate(bullet, transform.position, Quaternion.identity); //tạo ra bản sao của viên đạn: truyền thông số viên đạn, vị trí, và k cho xoay
            }
        }   
    }

    void PlanMovement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;//di chuyển theo trục x

        float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;//di chuyển theo trục y

        myBody.velocity = new Vector2(xAxis, yAxis);
    }

    IEnumerator Shoot() // hàm có kiểu trả về là 1 coroutine
    {
        canShoot = false;

        Vector3 temp = transform.position;
        temp.y += 0.5f;

        Instantiate(bullet, temp, Quaternion.identity); //bắn ra đạn
        yield return new WaitForSeconds(0.2f); //khoảng 2s chờ
        canShoot = true;
    }

    public void Death()
    {
        GamePlayController1.instance.PlaneDiedShowPanel(); //truy xuất đến hàm PlanelDiedShowPanel() thông qua instance 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Damage(int damage)
    {
        ourHearth -= damage;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.CompareTag("RedBullet"))
        {
            Destroy(target.gameObject);
        }
       
    }

}
