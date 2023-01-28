using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonePile : MonoBehaviour
{
    private int boneCounter = 0;

    public int GetBones()
    {
        return boneCounter;
    }

    public void AddBones()
    {
        boneCounter++;
    }

    public void RemoveBones()
    {
        boneCounter--;
        if (boneCounter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
