using MontyHall.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall.Business.Interfaces
{
  public interface IMontyHallProblem
  {
	/// <summary>
	/// Calculates the probability.
	/// </summary>
	/// <param name="reps">The reps.</param>
	/// <returns></returns>
	MhpResult CalculateProbability(int reps);
  }
}
