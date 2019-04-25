using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour //UNITY A DEUX MANIERE D'IMPLEMENTER UNE SERIE DE DONNEES, ARRAY OU LA LISTE
                                         // LA LISTE EST UTILISE LORSQUE l'on doit resize le tout PENDANT la durée de l'application
                                         // L'ARRAY EST UTILISE LORSQUE l'on ne va pas resize le nombre
{
    public Question[] questions;    // DE CETTE MANIERE LA SERIALISATION SE FAIT DIRECTEMENT, pourquoi ? Car dans la classe question, celle-ci est sérialisé
    private static List<Question> unansweredQuestion;//on va refaire une liste pour pouvoir supprimer les questions de la listes déjà reçus  INCROYABLE DU CUL
    private static List<Sprite> unansweredImage;                                                 //Question non répondus
    private Question currentQuestion;
    [SerializeField]
    private Image currentImage;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private Sprite[] questImage;


    [SerializeField]
    private float timeBetweenQuestion = 1f;
    private int reponse;
    private int goodAnswer;

    void Start()
    {
        if (unansweredQuestion == null || unansweredQuestion.Count == 0)
        {
            goodAnswer = 0;
            reponse = 0;
            unansweredQuestion = questions.ToList<Question>(); //ON A AJOUTER LES SYSTEM LINQ pour pouvoir utiliser les listes très facilement
            unansweredImage = questImage.ToList<Sprite>();
        }

        SetCurrentQuestion();

        Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);

       
    }

    private void SetCurrentQuestion()
    {
        int randomQuestionIndex = UnityEngine.Random.Range(0, unansweredQuestion.Count);
        currentQuestion = unansweredQuestion[randomQuestionIndex]; 
        currentImage.sprite = unansweredImage[randomQuestionIndex];


        //On met la question dans la variable

        factText.text = currentQuestion.fact;
        //unansweredQuestion.RemoveAt(randomQuestionIndex);                               //On supprime de la liste

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "CORRECT!";
            falseAnswerText.text = "WRONG!";
        } else
        {
            trueAnswerText.text = "WRONG!";
            falseAnswerText.text = "CORRECT!";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestion.Remove(currentQuestion); //on enlève l'élément pas l'index
        unansweredImage.Remove(currentImage.sprite);
        yield return new WaitForSeconds(timeBetweenQuestion);
        ++reponse;
        if (reponse == questImage.Length)
        {
            factText.text = ("you have " + goodAnswer + " correct answers ;)");
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else
        {
            SetCurrentQuestion();
        }
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void userselectedtrue()
    {

        if (currentQuestion.isTrue)
        {
            factText.text = ("CORRECT!");
            Debug.Log("CORRECT!");
            ++goodAnswer;
        } else
        {
            factText.text = ("WRONG!");
            Debug.Log("WRONG!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userselectedfalse()
    {

        if (currentQuestion.isTrue)
        {
            Debug.Log("WRONG!");
            factText.text = ("WRONG!");
        }
        else
        {
            Debug.Log("CORRECT!");
            factText.text = ("CORRECT!");
            ++goodAnswer;
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}
