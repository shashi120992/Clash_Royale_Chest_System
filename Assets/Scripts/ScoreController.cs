using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        public Text Cointext;
        public Text GemsText;

        private int CoinScore = 500;
        private int gemsscore = 50;

        private void Awake()
        {
            Cointext = GetComponent<Text>();
            GemsText = GetComponent<Text>();
        }
        public void increaseCoinScore(int incriment)
        {
            CoinScore += incriment;
            RefreshUI();
        }

        public void increaseGemsScore(int incriment)
        {
            gemsscore += incriment;
            RefreshUI();
        }

        public void Start()
        {
            RefreshUI();
        }
        private void RefreshUI()
        {
            Cointext.text = "Coins : " + CoinScore;
            GemsText.text = "Gems : " + gemsscore;
        }
    }
}