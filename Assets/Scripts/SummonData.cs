using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonData
{
    public GameObject unit;
    public GridPosition summonPosition;

    public SummonData(GameObject unit, GridPosition summonPosition)
    {
        this.unit = unit;
        this.summonPosition = summonPosition;
    }
}
