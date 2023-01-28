using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private GameObject currentPageOpen;

    public void OpenPage(GameObject tutorialPage)
    {
        tutorialPage.SetActive(true);
        if (currentPageOpen)
        {
            currentPageOpen.SetActive(false);
        }
        currentPageOpen = tutorialPage;
    }

    public void CloseTutorial()
    {
        currentPageOpen.SetActive(false);
        currentPageOpen = null;
    }
}
