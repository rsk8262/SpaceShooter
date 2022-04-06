using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /***Variables***/
    static public ObjectPool POOL;

    #region POOL Singleton
    void CheckPoolIsInScene()
    {
        if (POOL == null)
        {
            POOL = this;
        }
        else
        {
            Debug.LogError("POOL.Awake() - Attempted to assign a second ObjectPool.POOL");
        }

    }
    #endregion

    private Queue<GameObject> projectiles = new Queue<GameObject>(); //new queue of projectiles

    [Header("Pool settings")]
    public GameObject projectilePrefab;
    public int poolStartSize = 5;


    /***Methods***/

    private void Awake()
    {
        CheckPoolIsInScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
