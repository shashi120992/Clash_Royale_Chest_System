using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName ="New Chest", menuName ="Chest")]
    public class ChestManager : ScriptableObject
    {
        public string m_Chest;

        public int m_Coins;
        public int m_Gems;
        
    }
}