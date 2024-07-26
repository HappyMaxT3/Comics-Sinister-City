using UnityEngine;

namespace Main
{
    [CreateAssetMenu(fileName = "NewDifficultyData", menuName = "Difficulty/DifficultyData")]
    public class DifficultyData : ScriptableObject
    {
        public string Name;
        public float PlayerHPMultiplier;
        public float EnemyHPMultiplier;
        public float EnemyDamageMultiplier;
    }
}