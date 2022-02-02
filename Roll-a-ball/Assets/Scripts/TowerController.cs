using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class TowerController : MonoBehaviour
{
    private Rigidbody rb;
    public int healthPoints;
    public GameObject gameOverTextObject;
    public TextMeshProUGUI healthPointsText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        healthPoints = 100;
        setHPText();
        gameOverTextObject.SetActive(false);
    }


    void setHPText()
    {
        healthPointsText.text = "HP: " + healthPoints.ToString();
        if(healthPoints <= 0)
        {
            gameOverTextObject.SetActive(true);
        }
    }

    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Balloon"))
        {
            other.gameObject.SetActive(false);
            healthPoints--;
            setHPText();
        }
    }
}
