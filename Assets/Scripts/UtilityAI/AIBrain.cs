using System;
using UnityEngine;
using Core;

namespace UtilityAI
{
    public class AIBrain : MonoBehaviour
    {
        public Action BestAction { get; set; }
        private NPCController npc;
        public bool finishedDeciding;

        private void Start()
        {
            npc = GetComponent<NPCController>();
        }

        private void Update()
        {
            if (BestAction is null)
            {
                DecideBestAction(npc.actionsAvailable);
            }
        }

        public void DecideBestAction(Action[] actionsAvailable)
        {
            float score = 0f;
            int nextBestActionIndex = 0;
            for (int i = 0; i < actionsAvailable.Length; i++)
            {
                if (ScoreAction(actionsAvailable[i]) > score)
                {
                    nextBestActionIndex = i;
                    score = actionsAvailable[i].Score;
                }
            }

            BestAction = actionsAvailable[nextBestActionIndex];
            finishedDeciding = true;
        }

        public float ScoreAction(Action action)
        {
            float score = 1f;
            for (int i = 0; i < action.considerations.Length; i++)
            {
                float considerationScore = action.considerations[i].ScoreConsideration();
                score *= considerationScore;

                if (score == 0)
                {
                    action.Score = 0;
                    return action.Score;
                }
            }
            
            float originalScore = score;
            float modFactor = 1 - (1 / action.considerations.Length);
            float makeupValue = (1 - originalScore) * modFactor;
            action.Score = originalScore + (makeupValue * originalScore);

            return action.Score;
        }
    }
}
