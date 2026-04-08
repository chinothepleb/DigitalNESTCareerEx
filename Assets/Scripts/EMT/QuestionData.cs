using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObjects / Question", order = 1)]
public class QuestionData : ScriptableObject
{
    public string question;
    public string category;
    [Tooltip("The correct answer answer should always be first, they are randomized later.")]
    public string[] answers;
}
