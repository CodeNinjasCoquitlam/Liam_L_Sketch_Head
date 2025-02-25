using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;


    [Header("Platform Object")]
    public GameObject pltfrm;
    public float yPos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (!instance)
        {
            instance = this;
            SpawnInitialPlatforms();
        }
        
    }

    private void SpawnInitialPlatforms()
    {
        for (int i = 0; i < 100; i++)
        {
            SpawnPlatform();
        }
    }

    // Update is called once per frame
    private void SpawnPlatform()
    {
        float xPosition = Random.Range(-3f, 3f);
        Instantiate(instance.pltfrm, new Vector3(xPosition, instance.yPos, 1), Quaternion.identity);
        instance.yPos += 2.5f;
    }

    public static void MovePlatformToTop(GameObject platform)
    {
        float xPosition = Random.Range(-3f, 3f);
        platform.transform.position = new Vector3(xPosition, instance.yPos, 0);
        instance.yPos += 2.5f;
    }
}


