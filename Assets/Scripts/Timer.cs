using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Timer : MonoBehaviour
    {
        bool timeActive = false;
        float CurrentTime;
        public float startHours;
        public Text CurrentTimeText;
        [HideInInspector] ChestPooler chestPooler;

        private void Start()
        {
            CurrentTime = startHours * 3600;
        }

        private void Update()
        {
            if(timeActive == true)
            {
                CurrentTime = CurrentTime - Time.deltaTime;
                if(CurrentTime <= 0)
                {
                    timeActive = false;
                    Start();
                   //deactivating the game object
                    Debug.Log("Time finished Your Gift is Ready");
                }
            }
            TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
            CurrentTimeText.text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();

        }

        public void StartTimer()
        {
            timeActive = true;
        }
    }
}