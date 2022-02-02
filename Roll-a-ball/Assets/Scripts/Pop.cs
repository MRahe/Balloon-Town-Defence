using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pop : MonoBehaviour
{
    private GameManager gameManager;
    private TextMeshProUGUI balloonCountText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void Bang()
    {
        gameManager.updateScore();
    }


}
