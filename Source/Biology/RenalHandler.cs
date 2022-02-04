using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RenalHandler : MonoBehaviour,IVirtualButtonEventHandler
{
    [SerializeField] private Animator RenalAnimator;
    [SerializeField] private GameObject Model;
    [SerializeField] private GameObject Labellings;
    [SerializeField] private GameObject RotateButton;
    [SerializeField] private GameObject LabelButton;
    [SerializeField] private GameObject InfoButton;
    // Start is called before the first frame update
    void Start()
    {
        RotateButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        LabelButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        InfoButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        RenalAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        /*switch(vb.VirtualButtonName)
        {
            case "RotateRenalButton" :
            RenalAnimator.Play("RenalAnim");
            Debug.Log("Rotating");
            break;
            case "ShowRenalLabels" :

            break;
            default :
            RenalAnimator.Play("none");
            Labellings.SetActive(false);
            break;
        }*/
        if(vb.VirtualButtonName == "RotateRenalButton")
        {
            RenalAnimator.Play("RenalAnim");
        }
        else if (vb.VirtualButtonName == "ShowRenalLabels")
        {
            Labellings.SetActive(true);
            Debug.Log("ShowingInfo");
        }
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        /*switch(vb.VirtualButtonName)
        {
            case "RotateRenalButton" :
            RenalAnimator.Play("None");
            Debug.Log("Stopped Rotating");
            break;
            case "ShowRenalLabels" :
            Labellings.SetActive(false);
            Debug.Log("Stopped ShowingInfo");
            break;
            default :
            RenalAnimator.Play("none");
            Labellings.SetActive(false);
            break;
        }*/
        if(vb.VirtualButtonName == "RotateRenalButton")
        {
            RenalAnimator.Play("None");
        }
        else if (vb.VirtualButtonName == "ShowRenalLabels")
        {
            Labellings.SetActive(false);
            Debug.Log("ShowingInfo");
        }
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }
}
