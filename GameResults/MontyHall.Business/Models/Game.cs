using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall.Business.Models
{
  public class Game
  {
	/// <summary>
	/// Gets or sets the game number.
	/// </summary>
	/// <value>
	/// The game number.
	/// </value>
	public int GameNumber { get; set; } = -1;
	/// <summary>
	/// Gets or sets the game result.
	/// </summary>
	/// <value>
	/// The game result.
	/// </value>
	public string GameResult { get; set; } = "Lose";
	/// <summary>
	/// Gets or sets the doors.
	/// </summary>
	/// <value>
	/// The doors.
	/// </value>
	public List<Door> Doors { get; set; } = new List<Door>();

	/// <summary>
	/// Initializes a new instance of the <see cref="Game"/> class.
	/// </summary>
	/// <param name="car">The car.</param>
	public Game(int car) 
    {
      for (int i=1; i<=3; i++)
	  {
        var door = new Door();
        Doors.Add(door);
		if (car == i)
		{
		  door.DoorValue = true;
		}        
	  }
	  GameNumber = new Random().Next(1, 4);
	  if (Doors[GameNumber - 1].DoorValue)
	  {
		GameResult = "Win";
	  }
	}
  }
}
