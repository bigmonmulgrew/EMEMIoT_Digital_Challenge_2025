using UnityEngine;

public class ForceAspectRatio : MonoBehaviour
{
    // Target aspect ratio for Galaxy S24 (1080x2340)
    private readonly float targetAspect = 1080f / 2340f;

    void Start()
    {
        // Force portrait orientation
        Screen.orientation = ScreenOrientation.Portrait;

        // Only apply on non-mobile builds (mobile handles this automatically)
#if UNITY_STANDALONE || UNITY_WEBGL
        ApplyAspect();
#endif
    }

    void ApplyAspect()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = Camera.main;
        if (!cam) return;

        if (scaleHeight < 1.0f)
        {
            // Add letterbox (horizontal bars)
            Rect rect = cam.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            cam.rect = rect;
        }
        else
        {
            // Add pillarbox (vertical bars)
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = cam.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            cam.rect = rect;
        }
    }
}
