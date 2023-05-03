using Godot;
using System;

public partial class arrastapracima : Node2D
{
	private bool selected = false;

	private void _ready()
	{
		// Do nothing for now
	}

	private void _process(float delta)
	{
		if (selected)
		{
			FollowMouse();
		}
	}

	private void FollowMouse()
	{
		Position = GetGlobalMousePosition();
	}

	private void _on_Area_input_event(Viewport viewport, InputEvent @event, int shapeIdx)
	{
		if (@event is InputEventMouseButton && ((InputEventMouseButton)@event).ButtonIndex == (int)ButtonList.Left)
		{
			if (@event.Pressed)
			{
				selected = true;
			}
			else
			{
				selected = false;
			}
		}
	}
}



