using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall.Business.Models
{
  public class MhpResult
  {
	/// <summary>
	/// Gets or sets the wins.
	/// </summary>
	/// <value>
	/// The wins.
	/// </value>
	public int Wins { get; set; } = 0;
	/// <summary>
	/// Gets or sets the losses.
	/// </summary>
	/// <value>
	/// The losses.
	/// </value>
	public int Losses { get; set; } = 0;
	/// <summary>
	/// Gets or sets the tryies.
	/// </summary>
	/// <value>
	/// The tryies.
	/// </value>
	public int Tryies { get; set; } = 0;
  }
}
