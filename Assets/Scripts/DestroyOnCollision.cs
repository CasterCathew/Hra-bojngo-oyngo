using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private Text txt;
    public static int score = 0;
    
    public void Start()
    {
        GameObject objText = GameObject.FindGameObjectWithTag("ScoreLabel");
        if (objText != null)
        {
            Debug.Log("Našli jsme objText");
            txt = objText.GetComponent<Text>();
            UpdateScoreUI();
        }

    }

    public void Addscore(int newScore)
    {
        score += newScore;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (txt != null)
        {
            txt.text = "Score:" + score;            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Cube"))
        {

            Debug.Log(txt);

            Debug.Log(collision.gameObject.transform.localScale.x);
            float cubeSize = collision.gameObject.transform.localScale.x;
            int scoretoAdd = Mathf.RoundToInt(cubeSize);
            Addscore(scoretoAdd);
            Destroy(collision.gameObject);
        }
    }


}
