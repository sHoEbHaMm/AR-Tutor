using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class SkeleHandler : MonoBehaviour,IVirtualButtonEventHandler
{
    [SerializeField] private Animator SkeleAnimator;
    [SerializeField] private GameObject Model;
    [SerializeField] private GameObject SkeleInfo;
    [SerializeField] private GameObject SkeleLabels;
    [SerializeField] private GameObject RotateButton;
    [SerializeField] private GameObject LabelButton;
    [SerializeField] private GameObject InfoButton;
    // Start is called before the first frame update
    void Start()
    {
        RotateButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        LabelButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        InfoButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        SkeleAnimator = GetComponentInChildren<Animator>();
        SkeleLabels.SetActive(false);
        SkeleInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "RotateSkeleton")
        {
            SkeleAnimator.Play("SkeleAnim");
        }
        else if (vb.VirtualButtonName == "SkeleInfo")
        {
            SkeleInfo.SetActive(true);
            //SkeleInfo.SetActive(true);
            Debug.Log("ShowingInfo");
        }
        else if (vb.VirtualButtonName == "SkeleLabel")
        {
            SkeleLabels.SetActive(true);
            //SkeleInfo.SetActive(true);
            Debug.Log("ShowingLabels");
        }
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "RotateSkeleton")
        {
            SkeleAnimator.Play("Null");
        }
        else if (vb.VirtualButtonName == "SkeleInfo")
        {
            SkeleInfo.SetActive(false);
            //SkeleInfo.SetActive(true);
            Debug.Log("ShowingInfo");
        }
        else if (vb.VirtualButtonName == "SkeleLabel")
        {
            SkeleLabels.SetActive(false);
            //SkeleInfo.SetActive(true);
            Debug.Log("ShowingLabels");
        }        
    }
}
