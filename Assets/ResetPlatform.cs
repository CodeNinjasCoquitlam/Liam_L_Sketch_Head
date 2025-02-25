using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlatform : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        GameController.MovePlatformToTop(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
