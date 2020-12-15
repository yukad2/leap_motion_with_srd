using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _CubePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow)) {
            MakeCube();
        }
    }

    void MakeCube(){
        Instantiate(_CubePrefab);
    }
}
