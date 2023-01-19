using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
  public int playScore;
  public Text scoreText;

  [ContextMenu("Increase score")]
  public void addScore()
  {
    playScore = playScore + 1;
    scoreText.text = playScore.ToString();
  }
}
