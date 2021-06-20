using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ChestPooler : MonoBehaviour
    {
        public Dictionary<string, Queue<GameObject>> m_PoolDictionary;

        [System.Serializable]
        public class Pool
        {
            public string tag;
            public GameObject ChestPrefab;
            public int size;

        }

        #region Singleton
        public static ChestPooler Instance;
        private void Awake()
        {
            Instance = this; 
        }
        #endregion

        public List<Pool> pools;
        
        void Start()
        {
            
            m_PoolDictionary = new Dictionary<string, Queue<GameObject>>();

            foreach(Pool pool in pools)
            {
                Queue<GameObject> objectpool = new Queue<GameObject>();

               for(int i = 0; i < pool.size; i++)
                {
                    GameObject obj = Instantiate(pool.ChestPrefab);
                    obj.SetActive(false);
                    objectpool.Enqueue(obj);
                }

                m_PoolDictionary.Add(pool.tag, objectpool);
            }
        }
         
        public GameObject spawnfrompool(string tag, Vector3 position, Quaternion rotation, Transform parent)
        {
            if(!m_PoolDictionary.ContainsKey(tag))
            {
                Debug.LogWarning("pool with tag" + tag + "doesn't exists");
                return null;
            }
            
            GameObject objecttospawn = m_PoolDictionary[tag].Dequeue();
            objecttospawn.SetActive(true);
            objecttospawn.transform.position = position;
            objecttospawn.transform.rotation = rotation;
            objecttospawn.transform.parent = parent;

            m_PoolDictionary[tag].Enqueue(objecttospawn);

            return objecttospawn;
        }
    }
}