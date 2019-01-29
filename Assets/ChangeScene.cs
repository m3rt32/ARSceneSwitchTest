using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class ChangeScene : MonoBehaviour
{
    float counter;
    public Text _text;
    bool triggerOnce = true;
    // Update is called once per frame
    void Update()
    {
        _text.text = ((int)counter).ToString();
        counter += Time.deltaTime;
        if (counter > 15f && triggerOnce)
        {
            StopAR();
            triggerOnce = false;
        }
    }
    public void StopAR()
    {
        ARSubsystemManager.StopSubsystems();
        GameObject arsession = GameObject.Find("ARSession");
        Destroy(arsession);
        Invoke("Change", 1f);
    }
    
    private void Change()
    {
        SceneManager.LoadScene("AR2");
    }
}
