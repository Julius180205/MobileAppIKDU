using UnityEngine;
using TMPro;

public class math : MonoBehaviour
{

    public TextMeshProUGUI ourText;
    private int startingNumber = 10;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ourText.text = startingNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addNumber(int numberToAdd)
    {
        currentNumber = currentNumber + numberToAdd;
        ourText.text = currentNumber.ToString();

    }

    public void minusNumber(int numberToMinus)
    {
        currentNumber = currentNumber - numberToMinus;
        ourText.text = currentNumber.ToString();


    }

}
