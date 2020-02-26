using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingFloor : MonoBehaviour
{
    public GameObject Cube;
    int floorX = 0;
    int floorY = 1;
    int floorZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(floorX, floorY, floorZ), Quaternion.identity);
                floorZ += 1;
            }
            floorZ = 0;
            floorX += 1;
        }
        
    }

}
