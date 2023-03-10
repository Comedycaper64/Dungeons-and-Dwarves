using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindingUpdater : MonoBehaviour
{
    private void Start()
    {
        DestructibleCrate.OnAnyDestroyed += DestructibleCrate_OnAnyDestroyed;
        SummonSkeletonAction.OnAnySummonStart += SummonSkeletonAction_OnAnySummonStart;
        BoneFusionAction.OnAnySummonStart += BoneFusionAction_OnAnySummonStart;
        Unit.OnAnyUnitSpawned += Unit_OnAnyUnitSpawned;
    }

    private void Unit_OnAnyUnitSpawned(object sender, GridPosition e)
    {
        Pathfinding.Instance.SetIsWalkableGridPosition(e, true);
    }

    private void BoneFusionAction_OnAnySummonStart(object sender, GridPosition e)
    {
        Pathfinding.Instance.SetIsWalkableGridPosition(e, false);
    }

    private void SummonSkeletonAction_OnAnySummonStart(object sender, GridPosition e)
    {
        Pathfinding.Instance.SetIsWalkableGridPosition(e, false);
    }

    private void DestructibleCrate_OnAnyDestroyed(object sender, EventArgs e)
    {
        DestructibleCrate destructibleCrate = sender as DestructibleCrate;
        Pathfinding.Instance.SetIsWalkableGridPosition(destructibleCrate.GetGridPosition(), true);
    }
}
