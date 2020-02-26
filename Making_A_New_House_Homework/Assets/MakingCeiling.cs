using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingCeiling : MonoBehaviour
{
    public GameObject Cube;
    int ceilingX = 0;
    int ceilingY = 6;
    int ceilingZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(ceilingX, ceilingY, ceilingZ), Quaternion.identity);
                ceilingZ += 1;
            }
            ceilingZ = 0;
            ceilingX += 2;
        }
    }
}
