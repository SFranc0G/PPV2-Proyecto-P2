using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LessonContainer : MonoBehaviour
{
    [Header("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLection = 0;
    public int TotalLessons = 0;
    public bool AreAllLessonsComplete = false;

    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

    [Header("External GameObject")]
    public GameObject lessonContainer;
  
    void Start()
    {
        if (lessonContainer != null)
        {
            onUpdateUI();
        }
        else
        {
            Debug.LogWarning("GameOject Null, revisa las variables de tipo GameObject lessonContainer "+ name);
        }


    }

    public void onUpdateUI()
    {
        if ( StageTitle != null || LessonStage != null)
        { 
            StageTitle.text = "Leccion "+ Lection;
            LessonStage.text = "Leccion " + CurrentLection + " de " + TotalLessons; 
        }
        else
        {
            Debug.LogWarning("GameOject Null, revisa las variables de tipo TPM_text");
        }
    }

    //Este método activa/desactiva la ventana lessonContainer
    public void EnableWindow()
    {
        onUpdateUI();

    if ( lessonContainer.activeSelf ) 
    {
        //Desactiva el objeto si está activo
        lessonContainer.SetActive(false);
    }
    else
    {
        //Activa el objeto si está desactivado
        lessonContainer.SetActive(true);
    }
    }


}
