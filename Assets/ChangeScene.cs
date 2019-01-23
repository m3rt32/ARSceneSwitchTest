using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{
    float counter;
    public Text _text;
    // Update is called once per frame
    void Update()
    {
        _text.text = ((int)counter).ToString();
        counter += Time.deltaTime;
        if (counter > 15f)
        {
            SceneManager.LoadScene("AR2");
        }
    }
}
