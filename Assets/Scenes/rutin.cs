using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rutin : MonoBehaviour
{
    public Image targetImage; 
    public Sprite newSprite;
    public GameObject text_bar; 
    public GameObject button_cont;
    public GameObject button_cont2;
    public GameObject button_cont3;

    
    // Drag the Image GameObject in the Unity Inspector      // Drag the new Sprite in the Unity Inspector      // Call this method to change the image     
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImage()    
    {   
        button_cont3.SetActive(false);      
        targetImage.sprite = newSprite;     
        text_bar.SetActive(false);
        button_cont.SetActive(false);
        button_cont2.SetActive(true);

    }
    public void ChangeImage2()    
    {         
        targetImage.sprite = newSprite;     
        text_bar.SetActive(false);
        button_cont.SetActive(false);
        button_cont2.SetActive(false);
        button_cont3.SetActive(true);

    }
    public void ChangeImage3()    
    {         
        targetImage.sprite = newSprite;     
        text_bar.SetActive(false);
        button_cont2.SetActive(false);
        button_cont3.SetActive(false);
        button_cont.SetActive(false);
    }
}
