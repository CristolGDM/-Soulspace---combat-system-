using ORKFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    static int currentCharacter = 0;
    private readonly int maxCharacter = 2;
    public void PreviousCharacter() {
        if(currentCharacter == 0) {
            currentCharacter = maxCharacter;
        } else {
            currentCharacter--;
        }
        SetCharacter();
    }

    public void NextCharacter() {
        if (currentCharacter == maxCharacter) {
            currentCharacter = 0;
        }
        else {
            currentCharacter++;
        }
        SetCharacter();
    }

    private void SetCharacter() {
        Debug.Log("Calling event with " + currentCharacter);
        ORK.GlobalEvents.Get(currentCharacter).Call();
        Debug.Log("Called event");
    }
}
