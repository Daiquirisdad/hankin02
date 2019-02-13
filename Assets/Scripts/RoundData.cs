using System.Collections;
using UnityEngine;

[System.Serializable]
public class RoundData
{
    public string name;
    public int timeLimitInSeconds;
    public int pointsAddedForCorrectAnswers;
    public QuestionData[] questions;
}
