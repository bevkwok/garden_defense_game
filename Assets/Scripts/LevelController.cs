using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject winLable;
    [SerializeField] GameObject loseLable;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLable.SetActive(false);
        loseLable.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if(numberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLable.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoad>().LoadMainMenu();
        // SceneManager.LoadScene("start screen");

    }

    public void HandleLoseCondition()
    {
        loseLable.SetActive(true);
        Time.timeScale = 0;

    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawnser();
    }

    private void StopSpawnser()
    {
        AttackerSpawner[] spawnserArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnserArray)
        {
            spawner.StopSpawing();
        }
    }
}
