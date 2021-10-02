using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour
{

    

    public void Shoot(Vector3 speed)
    {
        GetComponent<Rigidbody2D>().AddForce(speed);
        SpriteRenderer spriteR = cat_change.cat.GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cat");
        spriteR.sprite = sprites[0];
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "window")
        {
            SpriteRenderer spriteR = cat_change.cat.GetComponent<SpriteRenderer>();
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cat");
            spriteR.sprite = sprites[2];
            gameManager.I.addScore();
            Destroy(gameObject);
        }
    }
}
