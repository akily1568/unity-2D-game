using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //tính chiều cao của màn hình để vừa với BG
        var worldHeight = Camera.main.orthographicSize * 2f;
        // Debug.log (worldheight) => 10

        // tính chiều rộng của BG
        var worldWidth = worldHeight * Screen.width / Screen.height;
        // Debug.log (worldWidth)  

        // phóng to đúng kích thước tỉ lệ khung hình
        transform.localScale = new Vector3(worldWidth, worldHeight, 0f);
    }

}
