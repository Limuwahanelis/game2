using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContext
{
    public PlayerMovement playerMovement;
    public Action<bool> SetSlideMode;
    public Action<PlayerState> ChangeState;
    public Func<float,Action, IEnumerator> WaitAndExecuteFunction; 
    public AnimationManager anim;
    public PlayerAudioManager audioManager;
    public PlayerChecks playerChecks;
    public AbilityList abilityList;
    public PhysicsMaterial2D noFrictionMat;
    public CorutineHolder corutineHolder;
    public PlayerCombat playerCombat;
    public int numberOfPerformedWallJumps;
    public int maximumNumberOfwallJumps;
    public bool canPerformAirAttack;
    public PlayerHealthSystem playerHealthSystem;
    public Vector3 pushVector;
    public Vector3 wallPushVector;

}
