using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;
    //private ...

    [SerializeField]
    private Text factText;
    // Lisää napeille kysymyksen omat vaihtoehtotekstit.
    //private Text choiceText;
    [SerializeField]
    private List<Text> choiceText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        SetCurrentChoices();
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
        //choiceText.text = 
    }

    void SetCurrentChoices()
    {
        for (int i = 0; i < choiceText.Count; i++)
        {
            choiceText[i].text = currentQuestion.choices[i];

        }
        //Tänne vastausten sekoitus...
        List<string> choices = new List<string> { "1999", "1987", "1293", "1234" };
        for (int i = 0; i < choices.Count; i++)
        {
            string temp = choices[i];
            int randomIndex = Random.Range(i, choices.Count);
            choices[i] = choices[randomIndex];
            choices[randomIndex] = temp;
            // Tänne laittaa nappien nimet
            GUI.Button(new Rect(20, 100, 100, 30), choices[0]);
            GUI.Button(new Rect(280, 100, 100, 30), choices[1]);
            GUI.Button(new Rect(20, 150, 100, 30), choices[2]);
            GUI.Button(new Rect(280, 150, 100, 30), choices[3]);

        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

}
