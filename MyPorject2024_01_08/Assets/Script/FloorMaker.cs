using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMaker : MonoBehaviour
{
    public GameObject Floor;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(Floor, new Vector3(i, 0.0f, j), Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
