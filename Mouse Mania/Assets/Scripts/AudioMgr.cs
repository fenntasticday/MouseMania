using UnityEngine;

public class AudioMgr : MonoBehaviour
{
    public static AudioMgr Instance;

     void Awake()
    {
        if (Instance == null)
        {
            // If no instance exists, set this one as the instance
            Instance = this;
            // Mark the current GameObject to not be destroyed when loading new scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this new duplicate object
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
