using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text ScoreText;
    public float Speed;
    private Rigidbody RB;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        RB = gameObject.GetComponent<Rigidbody>();
        ScoreText.text = "Score: " + Score.ToString();
    }

    public void AddScore(int value)
    {
        Score += value;
        ScoreText.text = "Score: " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);

        RB.velocity = dir * Speed;
        //RB.AddForce(dir * Speed);
        //transform.Translate(dir * Time.deltaTime * Speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
        }
    }
}
