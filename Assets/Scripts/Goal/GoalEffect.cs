using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalEffect : MonoBehaviour, IGoalAble
{
    public void Goal()
    {
        Debug.Log("ゴール");
    }
}
