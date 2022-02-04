using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class KidneyHandler : MonoBehaviour,IVirtualButtonEventHandler
{
    [SerializeField] private Animator Kidneyrotation;
    [SerializeField] private GameObject Model;
    [SerializeField] private GameObject Labels;
    [SerializeField] private GameObject Info;
    [SerializeField] private GameObject RotateButton;
    [SerializeField] private GameObject LabelButton;
    [SerializeField] private GameObject InfoButton;
    // Start is called before the first frame update
    void Start()
    {
        RotateButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        LabelButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        InfoButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Kidneyrotation = GetComponentInChildren<Animator>();
        Info.SetActive(false);
        Labels.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "RotateButton")
        {
            Kidneyrotation.Play("KidneyRotation");
        }
        else if (vb.VirtualButtonName == "InfoButton")
        {
            Info.SetActive(true);
            //SkeleInfo.SetActive(true);
            Debug.Log("ShowingInfo");
        }
        else if (vb.VirtualButtonName == "LabelButton")
        {
            Labels.SetActive(true);
        }
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "RotateButton")
        {
            Kidneyrotation.Play("none");
        }
        else if (vb.VirtualButtonName == "InfoButton")
        {
            Info.SetActive(false);
            //SkeleInfo.SetActive(true);
            Debug.Log("Stopped ShowingInfo");
        }
        else if (vb.VirtualButtonName == "LabelButton")
        {
            Labels.SetActive(false);
        }
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }
}
