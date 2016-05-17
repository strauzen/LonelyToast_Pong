using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 0.1f;
    public string horizontal = "Vertical";
    Rigidbody2D rb2d;
    private int score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        score = 0;
        UpdateScoreText();

        Debug.Log(string.Join("\n",Input.GetJoystickNames()));
	}

    // Update is called once per frame
    void Update() {
        float movement_horizontal = Input.GetAxisRaw(horizontal);

        Vector2 movement = new Vector2(0, movement_horizontal);

        rb2d.MovePosition(rb2d.position + (movement * speed));

        //testUpdateScore();
    }

    void UpdateScoreText()
    {
        scoreText.text = name + " : " + score.ToString();
    }

    void testUpdateScore()
    {
        score += 1;
        UpdateScoreText();
    }
}
