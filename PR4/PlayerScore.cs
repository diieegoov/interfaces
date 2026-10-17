using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI rewardText;

    private int score = 0;
    private int rewards = 0;

    private void Start()
    {
        UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Escudo1"))
        {
            AddPoints(5);
        }
        else if (other.CompareTag("Escudo2"))
        {
            AddPoints(10);
        }
    }

    private void AddPoints(int points)
    {
        score += points;

        // Una recompensa por cada 100 puntos acumulados
        int newRewards = score / 100;

        if (newRewards > rewards)
        {
            rewards = newRewards;
            Debug.Log("¡Has conseguido una recompensa!");
        }

        UpdateUI();
        Debug.Log("Score: " + score);
    }

    private void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;

        if (rewardText != null)
            rewardText.text = "Reward: " + rewards;
    }
}