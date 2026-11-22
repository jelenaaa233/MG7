using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    public GameObject[] sparrows;
    public Transform player;
    public float interactionDistance = 5f;

    void Update()
    {
        foreach (GameObject sparrow in sparrows)
        {
            if (sparrow == null || player == null)
                continue;

            float distance = Vector3.Distance(
                player.position,
                sparrow.transform.position
            );

            if (distance <= interactionDistance)
            {
                sparrow.SetActive(true);
            }
        }
    }
}
