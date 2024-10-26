using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField]
    bool isPickupOnCollision = true;

    void Start()
    {
        if (isPickupOnCollision)
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (isPickupOnCollision)
        {
            if (collider2D.tag == "Player")
            {
                Debug.Log("Exit");
                Application.Quit();
            }
        }
    }
}
