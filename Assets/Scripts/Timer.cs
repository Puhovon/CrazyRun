using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timer;
    
    public float maxTime = 60;

    private GameOverScreen _gameOverScreen;

    private void Awake()
    {
        _gameOverScreen = GetComponent<GameOverScreen>();
        print(Time.timeScale);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (maxTime > 0)
        {
            maxTime -= Time.deltaTime;
            double roundedTime = System.Math.Round(maxTime, 2);
            timer.text = roundedTime.ToString();
        }
        else
        {
            _gameOverScreen.GameOver();
        }
    }
}
