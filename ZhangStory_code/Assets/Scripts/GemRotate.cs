using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
 // Start is called before the first frame update
 public int rotateSpeed = 2;
 // Update is called once per frame
 void Update()
 {
  transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
 }
}
