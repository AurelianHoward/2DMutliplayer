using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject button;
    [SerializeField]
    GameObject door;
    [SerializeField]
    bool isPickupOnCollision = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
                door.SetActive(false);
                button.SetActive(false);
            }
            else
            {
                button.SetActive(true);
                door.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
