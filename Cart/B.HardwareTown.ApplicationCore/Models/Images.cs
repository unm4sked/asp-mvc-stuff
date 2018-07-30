using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B.HardwareTown.ApplicationCore.Domain;

namespace B.HardwareTown.ApplicationCore.Models
{
	public class Images
	{
		public Guid Id { get; set; }
		public byte[] Img { get; set; }

		private Images() { }

		public Images(byte[] img)
		{
			Id = Guid.NewGuid();
			Img = img.ToArray();
		}
    }
}
