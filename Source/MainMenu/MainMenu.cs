using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadBioScene()
    {
        SceneManager.LoadScene("Biology");
    }

    public void LoadAstroScene()
    {
        SceneManager.LoadScene("Astrology");
    }

    public void LoadChemScene()
    {
        SceneManager.LoadScene("Chemistry");
    }

    public void quit()
    {
        Application.Quit();
    }
}
