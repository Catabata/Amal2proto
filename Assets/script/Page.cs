using UnityEngine;

public class Page : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.PageCollected();
            gameObject.SetActive(false);
        }
    }
}
