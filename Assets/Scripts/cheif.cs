using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cheif : MonoBehaviour
{



    public static cheif cooker;
    public string cheif_state;
    public Animator animator;
    private AudioSource audio;
    public AudioClip catchSound;



    void Awake()
    {
        animator = GetComponent<Animator>();
        cooker = this;
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.catchSound;
        this.audio.loop = false;

    }
    // Start is called before the first frame update


    void start() 
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteR = cooker.GetComponent<SpriteRenderer>();

        if (cheif_state.Equals(spriteR.sprite.ToString()))
        {

        }
        else
        {
            cheif_state = spriteR.sprite.ToString();
        }

        if (gameManager.I.totalScore >0 &&cat_change.cat.state != "½Ä»§³ÉÀÌ" && cheif_state == "front (UnityEngine.Sprite)")
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cheif");
            spriteR.sprite = sprites[2];
            SpriteRenderer cat = cat_change.cat.GetComponent<SpriteRenderer>();
            Sprite[] cats = Resources.LoadAll<Sprite>("Sprites/Images/cat");
            cat.sprite = cats[4];
            ChangeEnd();
            
        }

        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f && animator.GetCurrentAnimatorStateInfo(0).IsName("cheif_check"))
        {
            
            animator.SetBool("isChecking", false);
        }

    }

    public void animationStart()
    {
    
        animator.SetBool("isChecking", true);
    
    }
    public void ChangeEnd()
    {
        SceneManager.LoadScene("endScenes");
    }
}
