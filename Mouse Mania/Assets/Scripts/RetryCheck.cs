using UnityEngine;

public class RetryCheck : MonoBehaviour
{

    public static RetryCheck Instance;
    public RectTransform uiElementRectTransform;
    // public PanelMover controlsPanel;
    // bool isRetry = false;

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
        Time.timeScale = 0f;
        uiElementRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        uiElementRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        uiElementRectTransform.pivot = new Vector2(0.5f, 0.5f);
        uiElementRectTransform.anchoredPosition = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
