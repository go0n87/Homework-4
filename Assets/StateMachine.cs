using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject activeScreen;
    // Start is called before the first frame update
    private GameObject currentScreen;    
    void Start()
    {
        activeScreen.SetActive(true);
        currentScreen = activeScreen;
    }

    public void ChangeScreen(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
 
    }

}
