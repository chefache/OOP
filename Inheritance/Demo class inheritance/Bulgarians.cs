using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_class_inheritance
{
    class Bulgarians : Europeans
    {
		private string hairColor;
		private int heigh;

		public Bulgarians(string hairColor, int heigh)
		{
			HairColor = hairColor;
			Heigh = heigh;
		}

		public string HairColor
		{
			get { return hairColor; }
			set { hairColor = value; }
		}

		public int Heigh
		{
			get { return heigh; }
			set { heigh = value; }
		}

		public string SayHello( string name)
		{
			return $"hello from " + name;
		}
	}
}
