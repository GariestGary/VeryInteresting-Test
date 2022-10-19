using System.Collections;
using System.Collections.Generic;
using BezierCurves;
using UnityEngine;
using VolumeBox.Toolbox;

[RequireComponent(typeof(BezierCurve))]
public class PathProvider : MonoCached
{
    private BezierCurve curve;

    public override void Rise()
    {
        curve = GetComponent<BezierCurve>();
    }
}
