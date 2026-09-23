using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MiceCollection miceNeeded;

    [Header("Cats Needs")]
    public int bobbyBigRequirements;
    public int gusRequirements;
    public int minniesRequirements;

    public bool canBribeBobby;
    public bool canBribeGus;
    public bool canBribeMinnie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canBribeBobby = false;
        canBribeGus = false;
        canBribeMinnie = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (miceNeeded.mice >= bobbyBigRequirements)
        {
            canBribeBobby = true;
        }
        
        if (miceNeeded.mice >= gusRequirements)
        {
            canBribeGus = true;
        }

        if (miceNeeded.mice >= minniesRequirements)
        {
            canBribeMinnie = true;
        }
    }
}
