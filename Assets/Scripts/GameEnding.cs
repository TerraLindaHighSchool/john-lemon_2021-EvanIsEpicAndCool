using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;


    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void Update()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel(exitBackgroundImageCanvasGroup);
        }
        else if (m_IsPlayerCaught)
        {
            EndLevel(caughtBackgroundImageCanvasGroup);
        }
    }

    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart)

    {
        m_Timer += Time.deltaTime;
        EndLevel(exitBackgroundImageCanvasGroup, false);
        imageCanvasGroup.alpha = m_Timer / fadeDuration;
        EndLevel(caughtBackgroundImageCanvasGroup, true);
        if (doRestart)
        {

        }
        else
        {
            Application.Quit();
        }
    }
}