using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject breadPrefeb;

 

    private void OnMouseDown()
    {
 
        GameObject bread = Instantiate(breadPrefeb) as GameObject;
        SpriteRenderer spriteR = bread.GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/bread");
        SpriteRenderer spriteR2 = gameObject.GetComponent<SpriteRenderer>();
        Sprite[] sprites2 = Resources.LoadAll<Sprite>("Sprites/Images/bread");
        if (gameManager.I.Rank > 3)
        {
            gameManager.I.Rank = 3;
        }
        spriteR2.sprite = sprites2[gameManager.I.Rank];
        spriteR.sprite = sprites[gameManager.I.Rank];
        bread.GetComponent<bread>().Shoot(new Vector3(0,9000, 100));
    }
}
