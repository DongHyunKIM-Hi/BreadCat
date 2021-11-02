using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_change : MonoBehaviour
{
    public static cat_change cat;
    public string state = "µµµœ≥…¿Ã";

    void Awake()
    {
        cat = this;
        this.state = "µµµœ≥…¿Ã";
    }

    private void OnMouseDown()
    {
        
        SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/bread_cat");
        spriteR.sprite = sprites[gameManager.I.Rank];
        state = "Ωƒªß≥…¿Ã";
        gameManager.I.combo = 0;
        gameManager.I.comboText.text = gameManager.I.combo.ToString();
    }

    private void OnMouseUp()
    {
        
        SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Images/cat");
        spriteR.sprite = sprites[2];
        state = "µµµœ≥…¿Ã";
        

    }

}
