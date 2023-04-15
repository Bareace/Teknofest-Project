using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(){
        SceneManager.LoadScene("1.a");
        
    }
    public void LoadScene2(){
        SceneManager.LoadScene("1.a_devam");
    }
    public void LoadScene3(){
        SceneManager.LoadScene("1.a.a");
    }
    public void LoadScene4(){
        SceneManager.LoadScene("bölüm2");
    }

    public void LoadScene5(){
        SceneManager.LoadScene("kapı");
    }
    public void LoadScene6(){
        SceneManager.LoadScene("bölüm3");
    }
    public void LoadScene7(){
        SceneManager.LoadScene("teneffüs");
    }
    public void LoadScene8(){
        SceneManager.LoadScene("3.a");
    }
    public void LoadScene9(){
        SceneManager.LoadScene("3.b");
    }
    public void LoadScene10(){
        SceneManager.LoadScene("1");
    }
}
