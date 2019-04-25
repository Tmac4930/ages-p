﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface for elements the player can interact with by pressing the Interact button.
/// </summary>
public interface IInteractive 
{
    string DisplayText { get; }

    //public string DisplayText { get { return displayText; } }
    void InteractWith();
}
