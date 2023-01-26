using ORKFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    static int currentCharacter = 0;
    private readonly int maxCharacter = 2;

    private Animator animator;

    private void Awake() {
        if (animator == null) {
            animator = GetComponentInChildren<Animator>();
        }
    }
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
        ORK.GlobalEvents.Get(currentCharacter).Call();
    }

    public void SetDirectionUp() {
        if (animator != null) {
            animator.SetInteger("Direction", 0);
        }
    }
    public void SetDirectionRight() {
        if (animator != null) {
            animator.SetInteger("Direction", 1);
        }
    }
    public void SetDirectionDown() {
        if (animator != null) {
            animator.SetInteger("Direction", 2);
        }
    }
    public void SetDirectionLeft() {
        if (animator != null) {
            animator.SetInteger("Direction", 3);
        }
    }
}
