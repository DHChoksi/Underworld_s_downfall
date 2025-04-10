using System.Collections.Generic;
using UnityEngine;
using BlankStudio.Constants;


[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
public class EnemyData : ScriptableObject
{
    [System.Serializable]
    public class EnemyProperties
    {
        public float Health => m_Health;
        public float Damage => m_Damage;
        public float Speed => m_Speed;
        public Constants.EnemyType EnemyType => m_EnemyType;
        public GameObject EnemyPrefab => m_EnemyPrefab;

        [SerializeField]
        private float m_Health = 0f;

        [SerializeField]
        private float m_Damage = 0f;

        [SerializeField]
        private float m_Speed = 0f;

        [SerializeField]
        private Constants.EnemyType m_EnemyType = Constants.EnemyType.None;

        [SerializeField]
        private GameObject m_EnemyPrefab = null;
    }

    [System.Serializable]
    public class Enemies
    {
        [SerializeField]
        private List<EnemyProperties> enemyPropertiesList = new List<EnemyProperties>();

        public List<EnemyProperties> EnemyPropertiesList => enemyPropertiesList;
    }

    [SerializeField]
    private Enemies enemiesData = new Enemies();

    public Enemies EnemiesData => enemiesData;
}
