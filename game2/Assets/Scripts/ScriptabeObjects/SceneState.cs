using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="SceneState")]
public class SceneState : ScriptableObject
{
    public SceneEnum sceneEnum;
    public List<BoolValue> puzzleStates = new List<BoolValue>();
    public List<BoolValue> pickupStates = new List<BoolValue>();
}
