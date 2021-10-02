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
        bread.GetComponent<bread>().Shoot(new Vector3(3000, 2000, 0));
    }
}
