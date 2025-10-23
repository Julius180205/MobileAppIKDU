using UnityEngine;

public class menuChanger : MonoBehaviour
{

    public GameObject videoPanel;
    public GameObject mathPanel;
    public GameObject foodPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePanel(string nameOfPanel)
    {
        videoPanel.SetActive(nameOfPanel == "video");
        foodPanel.SetActive(nameOfPanel == "food");
        mathPanel.SetActive(nameOfPanel == "math");


    }
}
