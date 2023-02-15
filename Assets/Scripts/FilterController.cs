using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterController : MonoBehaviour
{
    private CRTPostEffecter crtComponent;
    private ScanlinesEffect scanlinesComponent;

    private void Awake() {
        if (crtComponent == null) {
            crtComponent = GetComponent<CRTPostEffecter>();
        }
        if (scanlinesComponent == null) {
            scanlinesComponent = GetComponent<ScanlinesEffect>();
        }
    }

    private void SwitchFilterOnOff() {
        if(crtComponent.isActiveAndEnabled) {
            crtComponent.enabled = false;
            scanlinesComponent.enabled = false;
            return;
        }
        crtComponent.enabled = true;
        scanlinesComponent.enabled = true;
    }
}
