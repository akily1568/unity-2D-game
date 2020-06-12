using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour

{
    public float scrollSpeed; //biến tốc độ chuyển động BG

    private Material mat; // khai báo biến liên quan đến hình ảnh chuyển động 

    private Vector2 offset = Vector2.zero; //di chuyển theo 2 chiều x, y - biến độ di chuyển trong chuyển động

    //khởi tạo Material
    void Awake()
    {
        mat = GetComponent<Renderer> ().material; //gán mat với renderer và ánh xạ cho nó tới material
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = mat.GetTextureOffset("_MainTex"); //gán với hàm maintex chính
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += scrollSpeed * Time.deltaTime; //BG di chuyển từ trên xuống và di chuyển mượt 
        mat.SetTextureOffset("_MainTex", offset);
    }
}
