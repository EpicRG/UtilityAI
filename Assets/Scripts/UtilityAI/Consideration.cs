using UnityEngine;
using Core;

namespace UtilityAI
{
    public abstract class Consideration : ScriptableObject
    {
        public string name;
        private float _score;
        
        public float Score
        {
            get { return _score; }
            set
            {
                this._score = Mathf.Clamp01(value);
            }
        }

        public void Awake()
        {
            Score = 0;
        }

        public abstract float ScoreConsideration();
    }
}
