using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class AstroHandler : MonoBehaviour,IVirtualButtonEventHandler
{
    [SerializeField] private GameObject Sun;
    [SerializeField] private GameObject Mercury;
    [SerializeField] private GameObject Venus;
    [SerializeField] private GameObject Earth;
    [SerializeField] private GameObject Mars;
    [SerializeField] private GameObject Jupiter;
    [SerializeField] private GameObject Saturn;
    [SerializeField] private GameObject Uranus;
    [SerializeField] private GameObject Neptune;
    [SerializeField] private GameObject SunButton;
    [SerializeField] private GameObject MercuryButton;
    [SerializeField] private GameObject VenusButton;
    [SerializeField] private GameObject EarthButton;
    [SerializeField] private GameObject MarsButton;
    [SerializeField] private GameObject JupiterButton;
    [SerializeField] private GameObject SaturnButton;
    [SerializeField] private GameObject UranusButton;
    [SerializeField] private GameObject NeptuneButton;
    [SerializeField] private GameObject SunInfo;
    [SerializeField] private GameObject MercuryInfo;
    [SerializeField] private GameObject VenusInfo;
    [SerializeField] private GameObject EarthInfo;
    [SerializeField] private GameObject MarsInfo;
    [SerializeField] private GameObject JupiterInfo;
    [SerializeField] private GameObject SaturnInfo;
    [SerializeField] private GameObject UranusInfo;
    [SerializeField] private GameObject NeptuneInfo;

    // Start is called before the first frame update
    void Start()
    {
        AssignVButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "Sun")
        {
            Sun.SetActive(true);
            SunInfo.SetActive(true);
        }
        else if (vb.VirtualButtonName == "Mercury")
        {
            Mercury.SetActive(true);
            MercuryInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Earth")
        {
            Earth.SetActive(true);
            EarthInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Venus")
        {
            Venus.SetActive(true);
            VenusInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Mars")
        {
            Mars.SetActive(true);
            MarsInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Jupiter")
        {
            Jupiter.SetActive(true);
            JupiterInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Saturn")
        {
            Saturn.SetActive(true);
            SaturnInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Uranus")
        {
            Uranus.SetActive(true);
            UranusInfo.SetActive(true);   
        }
        else if (vb.VirtualButtonName == "Neptune")
        {
            Neptune.SetActive(true);
            NeptuneInfo.SetActive(true);   
        }        
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "Sun")
        {
            Sun.SetActive(false);
            SunInfo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "Mercury")
        {
            Mercury.SetActive(false);
            MercuryInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Earth")
        {
            Earth.SetActive(false);
            EarthInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Venus")
        {
            Venus.SetActive(false);
            VenusInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Mars")
        {
            Mars.SetActive(false);
            MarsInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Jupiter")
        {
            Jupiter.SetActive(false);
            JupiterInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Saturn")
        {
            Saturn.SetActive(false);
            SaturnInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Uranus")
        {
            Uranus.SetActive(false);
            UranusInfo.SetActive(false);   
        }
        else if (vb.VirtualButtonName == "Neptune")
        {
            Neptune.SetActive(false);
            NeptuneInfo.SetActive(false);   
        }        
        else{
            throw new UnityException (vb.VirtualButtonName + "not supported");
        }
    }

    private void AssignVButtons()
    {
        SunButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        MercuryButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        VenusButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        EarthButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        MarsButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        JupiterButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        SaturnButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        UranusButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        NeptuneButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

}
