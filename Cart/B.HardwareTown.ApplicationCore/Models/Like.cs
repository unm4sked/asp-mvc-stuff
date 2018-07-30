using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.ApplicationCore.Models
{
    public class Like
    {
		public Like(string userId)
		{
			UserId = userId;
		}
		public string UserId { get; set; }
    }
}
