using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
 public bool gamePaused = false;
 public AudioSource levelMusic;
 public GameObject pauseMenu;
 public AudioSource pauseJingle;

 void Update()
 {
  if (Input.GetButtonDown("Cancel"))
  {
   if (gamePaused == false)
   {
    pauseJingle.Play();
    Time.timeScale = 0;
    gamePaused = true;
    Cursor.visible = true;
    levelMusic.Pause();
    pauseMenu.SetActive(true);
   }
   else
   {
    Cursor.visible = false;
    gamePaused = false;
    Time.timeScale = 1;
    levelMusic.UnPause();
    pauseMenu.SetActive(false);
   }
  }
 }

 public void ResumeGame()
 {
  Cursor.visible = false;
  gamePaused = false;
  Time.timeScale = 1;
  levelMusic.UnPause();
  pauseMenu.SetActive(false);
 }
 public void RestartGame()
 {
  Cursor.visible = false;
  gamePaused = false;
  Time.timeScale = 1;
  levelMusic.UnPause();
  pauseMenu.SetActive(false);
  SceneManager.LoadScene(2);
 }
 public void QuitToMenu()
 {
  Cursor.visible = false;
  gamePaused = false;
  Time.timeScale = 1;
  levelMusic.UnPause();
  pauseMenu.SetActive(false);
  SceneManager.LoadScene(1);
 }
}
