using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomerOrderUI : MonoBehaviour
{
    public GameManager gameManager;
    public Image orderIcon;
    public TextMeshProUGUI orderText;

    public Image timeBarFill;

    public int RequestedValue { get; private set; }
    public bool IsExpired => timeRemaining <= 0f;
    public float TimeRemaining => timeRemaining;

    public float timeRemaining;
    public float totalDuration;

    Color customGreen = new Color(0.2f, 0.8f, 0.5f);  // softer green
    Color customYellow = new Color(1.0f, 0.8f, 0.2f); // warm yellow
    Color customRed = new Color(0.9f, 0.2f, 0.2f);    // darker red


    public void Init(int value, float duration, Sprite iconSprite)
    {
        RequestedValue = value;
        if (orderText != null) orderText.text = "Serve:";
        totalDuration = duration;
        timeRemaining = duration;
        if (timeBarFill != null) timeBarFill.fillAmount = 1f;

        if (orderIcon != null) 
        { 
            orderIcon.sprite = iconSprite; 
            orderIcon.enabled = iconSprite != null; 
        }
    }

public void UpdateTimer() //to be called from the manager
    {
        UpdateTimer(Time.deltaTime); //pass the delta time to update the timer based on real time
    }

    public void UpdateTimer(float deltaTime)
    {
        timeRemaining -= deltaTime;
        timeRemaining = Mathf.Max(timeRemaining, 0f);
        
        float fill = timeRemaining / totalDuration;
        timeBarFill.fillAmount = fill;

        // Change color based on remaining time
        if (fill > 0.5f)
        {
            timeBarFill.color = customGreen;
        }
        else if (fill > 0.25f)
        {
            timeBarFill.color = customYellow;  //sharp change of colours
        }
        else
        {
            timeBarFill.color = customRed;    //sharp change of colours
        }
    }

}
