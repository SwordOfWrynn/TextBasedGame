﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Save")]
public class Save : InputAction {

    public override void RepsondToInput(GameController controller, string[] separatedInputWords)
    {
        if (separatedInputWords.Length > 1)
            controller.saveLoadGame.SaveGame(separatedInputWords[1]);
        else
            controller.LogStringWithReturn("You must name your saved game");
    }

}
