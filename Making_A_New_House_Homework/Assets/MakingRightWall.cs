using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingRightWall : MonoBehaviour
{
    public GameObject Cube;
    int rightWallX = 0;
    int rightWallY = 1;
    int rightWallZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            { 
                Instantiate(Cube, new Vector3(rightWallX, rightWallY, rightWallZ), Quaternion.identity);
            rightWallZ += 1;
        }
        rightWallZ = 0;
        rightWallY += 1;
    }
}
    // Update is called once per frame
}
