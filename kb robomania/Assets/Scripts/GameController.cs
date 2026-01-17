using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject winScreen;
    private int numOfCrushers;
    private bool hasLost = false;
    public GameObject loseScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numOfCrushers = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("Player") == null)
        {
            hasLost = true;

            loseScreen.SetActive(true);
        }

    }

    public void DecreaseCrusherCount()
    {
        numOfCrushers -= 1;

        if(numOfCrushers == 0)
        {
            winScreen.SetActive(true);
        }
    }
}
