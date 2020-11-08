using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EyeQuoteScript : MonoBehaviour
{
    public TextMeshProUGUI sequenceText;

    void Start()
    {
        StartCoroutine(TextUpdate());
    }

    IEnumerator TextUpdate()
    {
        yield return new WaitForSeconds(3);
        sequenceText.SetText("The oldest and strongest emotion of mankind is fear, and the oldest and strongest kind of fear is [fear of the unknown]");
        yield return new WaitForSeconds(10);
        sequenceText.SetText("We live on [a placid island of ignorance] in the midst of black seas of infinity, and it was not meant that we should voyage far");
        yield return new WaitForSeconds(10);
        sequenceText.SetText("And as such, ultimate horror [often paralyses memory] in a merciful way.");
        yield return new WaitForSeconds(10);
        sequenceText.SetText("But I have always been [a seeker, a dreamer], and a ponderer on seeking and dreaming...");
    }


}
