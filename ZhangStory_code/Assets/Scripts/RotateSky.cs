using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
 public float rotateSpeed = 2.2f;
 void Update()
 {
  RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
 }
}
