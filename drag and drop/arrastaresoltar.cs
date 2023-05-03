using Godot;
using System;

public partial class arrastaresoltar : Node2D
{
	private bool clicando = false;
	private Vector2 offset = new Vector2();

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent && mouseEvent.ButtonIndex == (int)ButtonList.Left)
		{
			if (mouseEvent.Pressed)
			{
				clicando = true;
				offset = GetGlobalMousePosition() - Position;
			}
			else
			{
				clicando = false;
			}
		}
	}

	private void _process(float delta)
	{
		if (clicando)
		{
			Position = GetGlobalMousePosition() - offset;
		}
	}
}






