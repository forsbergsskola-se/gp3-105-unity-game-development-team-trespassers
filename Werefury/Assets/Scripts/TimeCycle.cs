using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour {
    public Light sun;
    public Transform sunTransform;
    public Gradient lightColorGradient;
    public float secondsInFullDay = 120f;

    void Update() {
        float t = Mathf.Repeat(Time.time, secondsInFullDay) / secondsInFullDay; // Repeats time after a full cycle
        float sunIntensity = Mathf.Clamp01(1 - Mathf.Abs(t * 2 - 1));
        float angle = Mathf.Lerp(0f, 360f, t);

        sun.color = lightColorGradient.Evaluate(t);
        sunTransform.rotation = Quaternion.Euler(angle, 0, 0);
        sun.intensity = sunIntensity;
    }
}
