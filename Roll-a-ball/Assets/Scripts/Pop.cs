using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pop : MonoBehaviour
{
    public int balloonsPopped;
    public TextMeshProUGUI balloonCountText;

    // Start is called before the first frame update
    void Start()
    {
        balloonCountText = GameObject.FindGameObjectWithTag("count").GetComponent<TextMeshProUGUI>();
        balloonsPopped = 0;
        setCountText(); 
    }

    public void Bang()
    {
        print("balloon popped.");
        balloonsPopped++;
        setCountText(); 
    }


    void setCountText()
    {
        balloonCountText.text = "Balloons Popped " + balloonsPopped.ToString();
    }
}
