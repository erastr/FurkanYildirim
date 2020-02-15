using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelCompleted : MonoBehaviour
{
    private int SphereCount = 0;
    public GameObject LevelWonPanel;

    private void OnCollisionEnter(Collision collision)
    {
        SphereCount++;
        if (SphereCount==3)
        {
            LevelWon();
        }
    }
    private void LevelWon()
    {
        Debug.Log("Kazandın");
        LevelWonPanel.SetActive(true);
        StartCoroutine(RestartGameIEnumerator(2));


    }

    IEnumerator RestartGameIEnumerator(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("MainScene");

    }
    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
