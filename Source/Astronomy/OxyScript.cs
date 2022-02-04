using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyScript : MonoBehaviour
{
    public Transform H1Target;

    public Transform H2Target;
    public float movSpeed;
    private int currentPoints;

    public GameObject H1;
    public GameObject H2;

    public bool H1_Obj = false;
    public bool H2_Obj = false;

    public bool Trigger1 = false;
    public bool Trigger2 = false;

    public GameObject OxySprite;
    public GameObject H2OSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(H1.transform.position == wayPoints[currentPoints].position || H2.transform.position == wayPoints[currentPoints].position)
        {
            currentPoints++;
        }
        if(currentPoints>=wayPoints.Length)
        {
            currentPoints = 0;
        }*/

        if(H1_Obj == true)
        {
            H1.transform.position = Vector3.MoveTowards(H1.transform.position, H1Target.position, movSpeed * Time.deltaTime);
            Trigger1 = true;
        }
        
        if (H2_Obj == true)
        {
            H2.transform.position = Vector3.MoveTowards(H2.transform.position, H2Target.position, movSpeed * Time.deltaTime);
            Trigger2 = true;
        }

        if(Trigger1 == true && Trigger2 == true)
        {
            //OxySprite.SetActive(false);
            H2OSprite.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "H1")
        {
            H1_Obj = true;
            Debug.Log("H1 Hit!");
        }
        
        if(other.transform.tag == "H2")
        {
            H2_Obj = true;
            Debug.Log("H2 Hit!");
        }
    }
}
