using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName="Name Subject", menuName ="ScriptableObject/New_Lesson", order =1)]
public class Subject : MonoBehaviour
{
    [Header("GameObject Configuration")]
    public int Lesson = 0;

    [Header("Lession Ques Configuration")]
    public List<Leccion> leccionList;


}
