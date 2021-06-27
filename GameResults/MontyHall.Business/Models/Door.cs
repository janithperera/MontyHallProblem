using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall.Business.Models
{
  public class Door
  {
	/// <summary>
	/// Gets or sets a value indicating whether [door value].
	/// </summary>
	/// <value>
	///   <c>true</c> if [door value]; otherwise, <c>false</c>.
	/// </value>
	public bool DoorValue { get; set; } = false;
	/// <summary>
	/// Gets or sets a value indicating whether this <see cref="Door"/> is status.
	/// </summary>
	/// <value>
	///   <c>true</c> if status; otherwise, <c>false</c>.
	/// </value>
	public bool Status { get; set; } = true;
  }
}
