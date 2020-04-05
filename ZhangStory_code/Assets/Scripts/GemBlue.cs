using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemBlue : MonoBehaviour
{
 public GameObject ScoreBox;
 public AudioSource CollectSound;
 void OnTriggerEnter()
 {
  GlobalScore.currentScore += 250;
  CollectSound.Play();
  Destroy(gameObject);
 }
}
