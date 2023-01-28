using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichLetterUI : MonoBehaviour
{
    public void CloseLetter()
    {
        if (this)
        {
            gameObject.SetActive(false);
        }
    }
}
