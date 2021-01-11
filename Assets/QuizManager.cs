using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Linq;


public class QuizManager : MonoBehaviour {
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private int score;
    [SerializeField]
    private Text scoreText;

 
     void Start() {
          if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
           Debug.Log("RESTARTED");
           unansweredQuestions = questions.ToList<Question> ();
          }
          setCurrentQuestion ();
        updateScore ();
        
     }

     void updateScore() {
        score = PlayerPrefs.GetInt("Punctaj");
        scoreText.text = "Punctaj: " + score;
     }
     public void AddScore (int amount) {
          score += amount;
        PlayerPrefs.SetInt("Punctaj", score);
        updateScore();
     }

     void setCurrentQuestion() {
      int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
      currentQuestion = unansweredQuestions[randomQuestionIndex];

      questionText.text = currentQuestion.question;

     }

     void Transition() {

          unansweredQuestions.Remove(currentQuestion);
          //Application.LoadLevel ("Game");
          Start ();
     }

     public void UserSelectTrue() {
        if (currentQuestion.isTrue)
        {
            Debug.Log("Corect");
            AddScore(50);
        }
        else
        {
            Debug.Log("Incorect");
            AddScore(-50);
        }
        Transition();
     }
     public void UserSelectFalse() {
          if (!currentQuestion.isTrue) {
           Debug.Log ("Corect");
           AddScore (50);
          }
          else
           Debug.Log ("Incorect");
           AddScore(-50);
        Transition();
         }

    public void QuitTheQuiz() 
    {
        SceneManager.LoadScene(1);
    }

}