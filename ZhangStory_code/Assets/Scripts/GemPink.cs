using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemPink : MonoBehaviour
{
 public GameObject ScoreBox;
 public AudioSource CollectSound;
 void OnTriggerEnter()
 {
  GlobalScore.currentScore += 500;
  CollectSound.Play();
  Destroy(gameObject);
 }
}
