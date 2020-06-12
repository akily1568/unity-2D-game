using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private GameObject enemy1;

    [SerializeField]
    private GameObject enemy2;

    private BoxCollider2D box;

    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D> ();
    }

    void Start()
    {
        StartCoroutine(SpawnerEnemy());
        StartCoroutine(SpawnerEnemy1());
        StartCoroutine(SpawnerEnemy2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnerEnemy() // hàm có kiểu trả về là 1 coroutine
    {

        yield return new WaitForSeconds(Random.Range(1f, 3f));

        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        Instantiate(enemy, temp, Quaternion.identity); //bắn ra đạn

        StartCoroutine(SpawnerEnemy());
    }


    IEnumerator SpawnerEnemy1() // hàm có kiểu trả về là 1 coroutine
    {

        yield return new WaitForSeconds(Random.Range(1f, 5f));

        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        Instantiate(enemy1, temp, Quaternion.identity); //bắn ra đạn

        StartCoroutine(SpawnerEnemy1());
    }

    IEnumerator SpawnerEnemy2() // hàm có kiểu trả về là 1 coroutine
    {

        yield return new WaitForSeconds(Random.Range(1f, 4f));

        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        Instantiate(enemy2, temp, Quaternion.identity); //bắn ra đạn

        StartCoroutine(SpawnerEnemy2());
    }
}
