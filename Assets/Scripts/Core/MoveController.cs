using UnityEngine;
using UnityEngine.AI;
using UtilityAI;

namespace Core
{
    public class MoveController : MonoBehaviour
    {
        private NavMeshAgent agent;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        public void MoveTo(Vector3 position)
        {
            agent.destination = position;
        }
    }
}
