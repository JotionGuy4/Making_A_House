using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingChimney : MonoBehaviour
{
    public GameObject Cube;
    int chimneyX = 0;
    int chimneyY = 1;
    int chimneyZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                Instantiate(Cube, new Vector3(chimneyX, chimneyY, chimneyZ), Quaternion.identity);
                chimneyY += 1;
            }
            chimneyY = 0;
            chimneyX += 1;
        }
        
    }

}
