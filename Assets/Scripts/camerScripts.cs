
using UnityEngine;

public class camerScripts : MonoBehaviour
{
    private void Awake()
    {
        Camera cam = GetComponent<Camera>();

        Rect rect = cam.rect;

        float scale_height = ((float) Screen.width/Screen.height) / ((float)9 / 16);
        float scale_width = 1f / scale_height;

        if (scale_height < 1)
        {
            rect.height = scale_height;
            rect.y = (1f - scale_height) / 2f;
        }
        else
        {
            rect.width = scale_width;
            rect.x = (1f - scale_width) / 2f;
        }
        cam.rect = rect;
    }
}
