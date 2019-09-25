using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleCollectionLog : MonoBehaviour
{
    public bool appleOneCollected = false;
    public bool appleTwoCollected = false;
    public bool appleThreeCollected = false;
    public bool appleFourCollected = false;
    public bool appleFiveCollected = false;

    public GameObject taskText;

    public void checkApples()
    {
        if(appleOneCollected && appleTwoCollected && appleThreeCollected && appleFourCollected && appleFiveCollected)
        {
            Debug.Log("You Have Enough Apples");
            taskText.SetActive(true);
        }
    }

    public void appleOneWasCollected()
    {
        this.appleOneCollected = true;
        checkApples();
    }

    public void appleTwoWasCollected()
    {
        this.appleTwoCollected = true;
        checkApples();
    }
    public void appleThreeWasCollected()
    {
        this.appleThreeCollected = true;
        checkApples();
    }
    public void appleFourWasCollected()
    {
        this.appleFourCollected = true;
        checkApples();
    }
    public void appleFiveWasCollected()
    {
        this.appleFiveCollected = true;
        checkApples();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
