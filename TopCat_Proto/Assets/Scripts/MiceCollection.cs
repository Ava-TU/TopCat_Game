using UnityEngine;
using TMPro;

public class MiceCollection : MonoBehaviour
{
    private int mice = 0;

    public TMP_Text miceText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mice"))
        {
            mice++;
            miceText.text = "Mice: " + mice.ToString();
            Debug.Log(mice);
            Destroy(other.gameObject);
        }
    }
}
