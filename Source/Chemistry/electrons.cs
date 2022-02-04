using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electrons : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);
    }
}
