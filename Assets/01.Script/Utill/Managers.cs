using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    #region Instance
    private static Managers _instance;
    private static Managers Instance { get { if (_instance == null) Init(); return _instance; } }
    #endregion

    #region Core
    private PoolManager _pool = new PoolManager();
    private SoundManager _sound = new SoundManager();
    private ResourceManager _resource = new ResourceManager();

    public static PoolManager Pool { get { return _instance._pool; } }
    public static SoundManager Sound { get { return _instance._sound; } }
    public static ResourceManager Resource { get { return _instance._resource; } }
    #endregion

    private void Awake()
    {
        Init();
    }

    static void Init()
    {
        if (_instance == null)
        {
            GameObject go = GameObject.Find("Managers");
            if (go == null)
            {
                go = new GameObject { name = "Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            _instance = go.GetComponent<Managers>();

            _instance._pool.Init();
        }
    }
}
