using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI balloonCountText;
    private int balloonsPopped;

    // Start is called before the first frame update
    void Start()
    {
        balloonsPopped = 0;
        balloonCountText.text = "Balloons Popped: " + balloonsPopped.ToString();
    }

    public void updateScore()
    {
        balloonsPopped++;
        balloonCountText.text = "Balloons Popped: " + balloonsPopped.ToString();

    }
}
