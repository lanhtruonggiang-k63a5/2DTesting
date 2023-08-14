using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragAndDrop;

public class PowersUI : ObjectContainerList<Power> {

    public PlayerTest2303 player;

	// Use this for initialization
	void Start () {
        CreateSlots(player.powers);
	}
}
