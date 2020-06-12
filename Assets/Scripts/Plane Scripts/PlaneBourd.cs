using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBourd : MonoBehaviour
{
    private float minX, minY, maxX, maxY;

    // Start is called before the first frame update
    void Start()
    {
        //ScreenToWorldPoint - là các điểm đánh dấu trên screen
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        minX = -bounds.x + 0.3f;
        maxX = bounds.x - 0.3f;

        minY = -bounds.y + 0.3f;
        maxY = bounds.y - 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;//lấy vị trí của máy bay
        
        //so sánh theo trục x
        if(temp.x < minX) //nếu nhỏ hơn
        {
            temp.x = minX;//đứng yên
        }else if(temp.x > maxX)
        {
            temp.x = maxX;
        }

        //so sánh theo trục y
        if(temp.y < minY)
        {
            temp.y = minY;
        }else if(temp.y > maxY)
        {
            temp.y = maxY;
        }

        //gán lại tọa độ
        transform.position = temp;
    }
}
