using UnityEngine;

public class FallMgr : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string targetLayerName = "Fall"; 

    public string targetLayerName2 = "WinZone"; 
    int targetLayer;
    int targetLayer2;

    public Vector3 respawnPos;

    public Health health;


    void Start()
    {
        targetLayer = LayerMask.NameToLayer(targetLayerName);
        if (targetLayer == -1)
        {
            Debug.LogError($"Layer '{targetLayerName}' does not exist! Check your Project Settings.");
        }
        targetLayer2 = LayerMask.NameToLayer(targetLayerName2);
        if (targetLayer2 == -1)
        {
            Debug.LogError($"Layer '{targetLayerName2}' does not exist! Check your Project Settings.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object's layer matches the target layer
        if (collision.gameObject.layer == targetLayer)
        {
            // Debug.Log("STarted colliding with the target layer: " + targetLayerName);
            this.gameObject.transform.position = respawnPos;
            health.healthUpdate();
        }

        if (collision.gameObject.layer == targetLayer2)
        {
            // Debug.Log("STarted colliding with the target layer: " + targetLayerName2);
            Time.timeScale = 0f;
            health.winPanel.PanelShow();
        }
    }
}
