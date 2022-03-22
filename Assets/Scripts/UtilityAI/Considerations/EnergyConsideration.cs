using UnityEngine;

namespace UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "EnergyConsideration", menuName = "UtilityAI/Considerations/Energy Consideration")]
    public class EnergyConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.6f;
        }
    }
}

