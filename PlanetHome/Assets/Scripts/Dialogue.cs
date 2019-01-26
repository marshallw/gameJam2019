﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Dialogue
{
    [TextArea(1,99)]
    public string[] sentences;
    public string name;
}
