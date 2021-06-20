using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class SlotManager : MonoBehaviour
    {
        public Transform slots;
        //public GameObject slots;
        //public GameObject[] slots; // not working
        public Button button;
        ChestPooler chestPooler;
        

        void Start()
        {
            chestPooler = ChestPooler.Instance;
        }
        private void Awake()
        {
            button.onClick.AddListener(alotSlot);
        }
        public void alotSlot()
        {
            /*
            for (int i = 0; i < slots.Length; i++)
            {

               if (gameObject.transform.childCount < 2)
                {
                    //means slot is empty
            */

                    int randomIndex = Random.Range(1, 4);
                    chestPooler.spawnfrompool("RareChest", slots.position, Quaternion.identity, transform.parent);
                    Debug.Log("Rare Chest Assigned to Slot2");
            /*
                }
            }
            */
        }
    }
}