using MontyHall.Business.Interfaces;
using MontyHall.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall.Business
{
  public class MontyHallProblem: IMontyHallProblem
  {
	/// <summary>
	/// Calculates the probability.
	/// </summary>
	/// <param name="reps">The reps.</param>
	/// <returns></returns>
	public MhpResult CalculateProbability(int reps) 
	{
	  var result = new MhpResult();
	  var games = new List<Game>();
	  for (int i=0; i < reps; i++)
	  {
		games.Add(new Game(new Random().Next(1, 4)));
	  }

	  result.Tryies = reps;
	  foreach(var game in games)
	  {
		if (String.Equals(game.GameResult, "Win"))
		{
		  result.Wins++;
		}
		result.Losses = reps - result.Wins;
	  }
	  return result;
	}
  }
}
