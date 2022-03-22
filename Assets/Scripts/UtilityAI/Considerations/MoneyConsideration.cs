using UnityEngine;

namespace UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "MoneyConsideration", menuName = "UtilityAI/Considerations/Money Consideration")]
    public class MoneyConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.1f;
        }
    }
}

