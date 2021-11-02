using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteR2 = gameObject.GetComponent<SpriteRenderer>();
        Sprite[] sprites2 = Resources.LoadAll<Sprite>("Sprites/Images/bread");
        spriteR2.sprite = sprites2[gameManager.I.Rank];
    }
}
