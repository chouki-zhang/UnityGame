using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
 public GameObject ScoreBox;
 public AudioSource CollectSound;
 void OnTriggerEnter()
 {
  GlobalScore.currentScore += 1000;
  CollectSound.Play();
  Destroy(gameObject);
 }
}
