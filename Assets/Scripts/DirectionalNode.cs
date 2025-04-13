using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        if(current == "left")
        {
            Debug.Log("Choose Left");
            sr.sprite = left;
        }
        else if(current == "right")
        {
            Debug.Log("Choose Right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose None");
            sr.sprite = none;
        }
    }
}
