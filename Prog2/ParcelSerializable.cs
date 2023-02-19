using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVApp
{
	[Serializable]
	public class ParcelSerializable
	{
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int Zip { get; set; }

		public ParcelSerializable()
			:this (string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0) { }

		public ParcelSerializable(string name, string address1, string address2, string city, 
			string state, int zip)
        {
			Name = name;
			Address1 = address1;
			Address2 = address2;
			City = city;
			State = state;
			Zip = zip;
        }


	}
}