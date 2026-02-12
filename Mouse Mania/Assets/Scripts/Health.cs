using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{

    public int health;

    public PanelMover winPanel;
    public PanelMover losePanel;

    public TextMeshProUGUI livesText;

    // public GameObject winArea;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        livesText.text = ("x" + health.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void healthUpdate()
    {
        health--;
        livesText.text = ("x" + health.ToString());
        if (health <= 0)
        {
            Time.timeScale = 0f;
            losePanel.PanelShow();
        }
    }

    // public void Win()
    // {
        
    // }
}
