using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip shootSound;


    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.shootSound;
        this.audio.loop = false;

    }


    public void Shoot(Vector3 speed)
    {
        GetComponent<Rigidbody2D>().AddForce(speed);
        SpriteRenderer spriteR = cat_change.cat.GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cat");
        spriteR.sprite = sprites[0];
        this.audio.Play();

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
