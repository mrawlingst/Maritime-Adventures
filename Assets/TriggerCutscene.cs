using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerCutscene : MonoBehaviour {

    public Text text;
    public GameObject image;
    public GameObject background;
    public GameObject toptext;
    public PlayerController playercontroller;
    public string message;

    void OnTriggerEnter(Collider other)
    {
        text.text = message;
        playercontroller.Movable = false;
        image.SetActive(true);
        toptext.SetActive(true);
        background.SetActive(true);
        StartCoroutine(BlockInput());
    }

    void OnTriggerExit(Collider other)
    {
    }

    IEnumerator BlockInput()
    {
        yield return new WaitForSeconds(5.0f);
        playercontroller.Movable = true;
        image.SetActive(false);
        toptext.SetActive(false);
        background.SetActive(false);
    }
}
