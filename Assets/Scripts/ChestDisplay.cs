using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ChestDisplay : MonoBehaviour
    {
        public ChestManager chestManager;
        public Text ChestName;
        public Text coinText;
        public Text GermText;

        void Start()
        {
            ChestName.text = chestManager.m_Chest;
            coinText.text = chestManager.m_Coins.ToString();
            GermText.text = chestManager.m_Gems.ToString();
        }

        
    }
}