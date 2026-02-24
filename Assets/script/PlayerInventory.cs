using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfPages { get; private set; }

    public UnityEvent<PlayerInventory> OnPageCollected;

    public void PageCollected()
    {
        NumberOfPages++;
        OnPageCollected.Invoke(this);
    }
}
