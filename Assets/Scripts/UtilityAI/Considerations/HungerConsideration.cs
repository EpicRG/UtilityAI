using UnityEngine;

namespace UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "HungerConsideration", menuName = "UtilityAI/Considerations/Hunger Consideration")]
    public class HungerConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.2f;
        }
    }
}

