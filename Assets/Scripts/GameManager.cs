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
                                                     //Question non répondus
    private Question currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private float timeBetweenQuestion = 1f;

    void Start()
    {
        if (unansweredQuestion == null || unansweredQuestion.Count == 0)
        {
            unansweredQuestion = questions.ToList<Question>(); //ON A AJOUTER LES SYSTEM LINQ pour pouvoir utiliser les listes très facilement
        }

        SetCurrentQuestion();

        Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);

       
    }

    private void SetCurrentQuestion()
    {
        int randomQuestionIndex = UnityEngine.Random.Range(0, unansweredQuestion.Count);
        currentQuestion = unansweredQuestion[randomQuestionIndex];                      //On met la question dans la variable

        factText.text = currentQuestion.fact;
        //unansweredQuestion.RemoveAt(randomQuestionIndex);                               //On supprime de la liste
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestion.Remove(currentQuestion); //on enlève l'élément pas l'index

        yield return new WaitForSeconds(timeBetweenQuestion);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void userselectedtrue()
    {

        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        } else
        {
            Debug.Log("WRONG!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userselectedfalse()
    {

        if (currentQuestion.isTrue)
        {
            Debug.Log("WRONG!");
        }
        else
        {
            Debug.Log("CORRECT!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}
