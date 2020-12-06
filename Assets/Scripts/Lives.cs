using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    [SerializeField] int lives = 3;
    [SerializeField] int damage = 1;

    Text livesText;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }


    // Update is called once per frame
    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();

            // FindObjectOfType<LevelLoad>().LoadYouLose();
        }
    }
}
