using UnityEngine;
using Core;

namespace UtilityAI
{
    public abstract class Action : ScriptableObject
    {
        public new string name;
        private float _score;

        public float Score
        {
            get { return _score; }
            set
            {
                this._score = Mathf.Clamp01(value);
            }
        }

        public Consideration[] considerations;
        
        public virtual void Awake()
        {
            Score = 0;
            
        }

        public abstract void Execute(NPCController npc);
    }
}

