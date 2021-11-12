using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using TMPro;

public class ControlMenu : MonoBehaviour
{
    public TMP_Text t;

    public TMP_InputField a;
    public TMP_Dropdown sin_cos;
    public TMP_InputField b;

    public TMP_Text equation;

    private void Start()
    {
        equation.text = "r = Asin(Bt)";
    }

    private void Update()
    {
        t.text = string.Format("t = {0}", Mathf.Round(SceneManager.i.clock * 1000f) / 1000f);
    }

    public void UpdateEquationText()
    {
        LimitVars();

        string newEquation = string.Format("r = {0}{1}({2}t)", a.text, sin_cos.options[sin_cos.value].text, b.text);
        equation.text = newEquation;
    }

    public void LimitVars()
    {
        if (a.text.Length > 0 && int.Parse(a.text) > 5)
        {
            a.text = "5";
        }

        if (b.text.Length > 0 && int.Parse(b.text) > 50)
        {
            b.text = "50";
        }
    }

    public void UpdateRadius()
    {
        MainCircle.instance.amplitude = int.Parse(a.text);
        MainCircle.instance.angleCoefficient = int.Parse(b.text);
    }
}
