using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public List<GameObject> sprites = new List<GameObject>();

    private void Start()
    {
        createSprites();
    }

    public void createSprites()
    {
        int randomSprite = 0;
        for (int i = -3; i < 3; i++)
        {
            for (int j = -7; j < 7; j++)
            {
                randomSprite = Random.Range(0, 4);
                Instantiate(sprites[randomSprite], new Vector2(j, i), Quaternion.identity);
            }
            
        }
    }

    public void DestroyObject()
    {
        if (true)
        {

        }
    }
}
