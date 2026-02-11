using UnityEngine;

public class FallMgr : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string targetLayerName = "Fall"; 
    public int targetLayer;

    public Vector3 respawnPos;


    void Start()
    {
        targetLayer = LayerMask.NameToLayer(targetLayerName);
        if (targetLayer == -1)
        {
            Debug.LogError($"Layer '{targetLayerName}' does not exist! Check your Project Settings.");
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
            Debug.Log("STarted colliding with the target layer: " + targetLayerName);
            this.gameObject.transform.position = respawnPos;
        }
    }

    // void OnCollisionExit(Collision collision)
    // {
    //     // Optional: Check when the collision ends
    //     if (collision.gameObject.layer == targetLayer)
    //     {
    //         Debug.Log("Stopped colliding with the target layer: " + targetLayerName);
    //     }
    // }
}
