using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingFront : MonoBehaviour
{
    public GameObject Cube;
    int frontX = 0;
    int frontY = 1;
    int frontZ = 5;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                Instantiate(Cube, new Vector3(frontX, frontY, frontZ), Quaternion.identity);
                frontY += 1;
            }
            frontY = 0;
            frontX += 2;
        }
    }

}
