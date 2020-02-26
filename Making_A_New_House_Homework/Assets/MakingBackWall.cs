using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingBackWall : MonoBehaviour
{
    public GameObject Cube;
    int backWallX = 0;
    int backWallY = 1;
    int backWallZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(backWallX, backWallY, backWallZ), Quaternion.identity);
                backWallX = 0;
            }
            backWallX = 0;
            backWallY += 2;

        }

    }
}
