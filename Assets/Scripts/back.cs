using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Update()
    {
        SpriteRenderer spriteR2 = gameObject.GetComponent<SpriteRenderer>();
        Sprite[] sprites2 = Resources.LoadAll<Sprite>("Sprites/Images/back");
        if (gameManager.I.Rank > 3)
        {
            gameManager.I.Rank = 3;
        }
        spriteR2.sprite = sprites2[gameManager.I.Rank];
    }
}
