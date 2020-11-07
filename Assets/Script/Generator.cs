using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    public GameObject cube;
    public Text text;

    void Update()
    {
        //Instantiate(cube, new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0), Quaternion.identity);
    }

    public void Test(string str)
    {
        //print(str+"\n");]
        Instantiate(cube, new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0), Quaternion.identity);
        text.text = str;
    }
}
