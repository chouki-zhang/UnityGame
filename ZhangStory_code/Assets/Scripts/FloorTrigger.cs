using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Collections;

public class FloorTrigger : MonoBehaviour
{
 // public GameObject house;
 public GameObject cart;
 public GameObject ele01;
 public GameObject ele02;
 public GameObject ele03;
 public GameObject ele04;
 public GameObject realWorld;
 public GameObject platForm;
 public GameObject bat;
 public GameObject mummy;
 public GameObject fire;

 void OnTriggerEnter()
 {
  // house.SetActive(true);
  cart.SetActive(true);
  ele01.SetActive(true);
  ele02.SetActive(true);
  ele03.SetActive(true);
  ele04.SetActive(true);
  realWorld.SetActive(true);
  platForm.SetActive(true);
  bat.SetActive(true);
  mummy.SetActive(true);
  fire.SetActive(true);
  Destroy(gameObject);
 }
}
