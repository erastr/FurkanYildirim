using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public List<GameObject> Spheres = new List<GameObject>();

    private void Update()
    {

        for (int i = 0; i < Spheres.Count; i++)
        {
            if (Spheres[i].transform.position.z<transform.position.z-0.6f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, Spheres[i].transform.position.z+0.6f);
            }
        }
    }
}
