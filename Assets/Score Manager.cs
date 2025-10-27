using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI ScoreText;
    private int currentScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        ScoreText.text = "HELLO WORLD";
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void AddScore(int amount)
    {
       
        currentScore += amount;
            UpdateScoreText();
    }
    void UpdateScoreText()
    {
        Debug.Log("Points should change");
        ScoreText.text = "Score:" + currentScore;
    }

}
