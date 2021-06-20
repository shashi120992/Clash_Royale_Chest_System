using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ButtonOnClick : MonoBehaviour
    {
        ChestPooler chestPooler;
        public Button button;
        public Transform parent;

        private string taga;

        void Start()
        {
            chestPooler = ChestPooler.Instance;
        }
        private void Awake()
        {
            button.onClick.AddListener(buttonClick);
        }
        public void buttonClick()
        {
            chestPooler.spawnfrompool("CommonChest", parent.position, Quaternion.identity, transform.parent);
            Debug.Log("Common Chest Assigned to Slot1");
        }
    }
}