using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
	public static ScoreControl Instance { get; private set; }
	public Text scoreText;
	public Text endScoreText;
	public Text highScoreText;
	public float pointsPerSecond = 1;
	float score;
	float highScore;

	void Awake() { Instance = this; }

	string ToString(string s, float x) {
		return s + " " + Mathf.Round(x);
	}
	void Update() {
		score += pointsPerSecond * Time.deltaTime;
		scoreText.text = ToString("score", score);
	}
	public void EndGame() {
		if (PlayerPrefs.HasKey("HighScore")) {
			highScore = PlayerPrefs.GetFloat("HighScore");
		}
		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetFloat("HighScore", highScore);
		}
		endScoreText.text = ToString("YOUR SCORE IS ", score);
		highScoreText.text = ToString("HIGH SCORE IS ", highScore);
	}
}
