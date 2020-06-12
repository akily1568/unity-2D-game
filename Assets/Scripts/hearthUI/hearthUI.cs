using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hearthUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] Hearthsprite;

    public Plane plane;

    public Image Hearth;

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.FindGameObjectWithTag("Player").GetComponent<Plane>();
    }

    // Update is called once per frame
    void Update()
    {
        Hearth.sprite = Hearthsprite[plane.ourHearth];
    }
}
