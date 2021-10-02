using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheif : MonoBehaviour
{



    public static cheif cooker;
    public string cheif_state;
    public Animator animator;
 


    void Awake()
    {
        animator = GetComponent<Animator>();
        cooker = this;
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

        if (cat_change.cat.state != "식빵냥이" && cheif_state == "front (UnityEngine.Sprite)")
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cheif");
            spriteR.sprite = sprites[2];
            Debug.Log("잡았다.");
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
    
}
