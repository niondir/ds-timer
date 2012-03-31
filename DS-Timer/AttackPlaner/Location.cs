using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace DS_Timer.AttackPlaner
{
	[XmlRoot]
	public struct Location
	{
		public static readonly Location Empty = new Location();
		public int X { get; set; }
		public int Y { get; set; }


		public Location(int x, int y)
			: this()
		{
			this.X = x;
			this.Y = y;
		}

		public static Location operator -(Location left, Location right)
		{
			return new Location(left.X - right.X, left.Y - right.Y);
		}

		public static Location operator +(Location left, Location right)
		{
			return new Location(left.X + right.X, left.Y + right.Y);
		}

		public static bool operator !=(Location left, Location right)
		{
			return !(left == right);
		}

		public static bool operator ==(Location left, Location right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((X % Int16.MaxValue) << 16) + (X % Int16.MaxValue);
			}
		}

		/*
		public static implicit operator Location(Point p)
		{
			Location l = new Location(p.X, p.Y);
			return l;
		}
		 * */

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (!(obj is Location)) return false;
			Location l = (Location)obj;

			if (l == this)
				return true;
			else
				return false;
		}

		public override string ToString()
		{
			return X + "|" + Y;
		}

	}
}
