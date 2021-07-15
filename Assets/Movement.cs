using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void moveObject()
    {
        
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 5f);
    }
}
