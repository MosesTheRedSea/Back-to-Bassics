using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAction : EnemyAction
{
    [SerializeField] private GameObject knifeFab;
    [SerializeField] private Spinning[] spinners;
    public override void StartAction()
    {
        base.StartAction();
        foreach (Spinning spinner in spinners)
        {
            spinner.speed = 5f;
        }
        
    }
    public override void StopAction()
    {
        base.StopAction();
        foreach (Spinning spinner in spinners)
        {
            spinner.speed = 0f;
        }
    }
}
