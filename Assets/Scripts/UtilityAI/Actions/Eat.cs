using Core;
using UnityEngine;

namespace UtilityAI.Actions
{
    [CreateAssetMenu(fileName = "Eat", menuName = "UtilityAI/Actions/Eat")]
    public class Eat : Action
    {
        public override void Execute(NPCController npc)
        {
            Debug.Log("I Ate Food!");
            npc.OnFinishedAction();
        }
        
    }

}
