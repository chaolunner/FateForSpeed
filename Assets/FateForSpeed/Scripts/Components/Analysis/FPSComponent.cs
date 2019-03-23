﻿using System.Collections.Generic;
using UnityEngine.UI;
using UniEasy.ECS;
using UnityEngine;
using UniEasy;
using System;

[Serializable]
public struct FPSColorRange
{
    public Color Color;
    [MinMaxRange(0, 300)]
    public RangedInt Range;
}

[ContextMenuAttribute("ECS/FPSComponent")]
public class FPSComponent : RuntimeComponent
{
    public int FrameRange = 60;
    public Text HighestFPSLabel, AverageFPSLabel, LowestFPSLabel;
    [Reorderable(elementName: null)]
    public List<FPSColorRange> ColorRamp;
}
