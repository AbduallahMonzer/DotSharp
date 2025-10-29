using System;
namespace DotSharp.Day04;

class IpAddr
{
	private int[] octets = new int[4];
	public IpAddr(int o1, int o2, int o3, int o4)
	{
		octets[0] = o1;
		octets[1] = o2;
		octets[2] = o3;
		octets[3] = o4;
	}

	public int this[int index]
	{
		get
		{
			if (index < 0 || index > 3)
				throw new IndexOutOfRangeException("ip has only 4 octets (0 to 3)");
			return octets[index];
		}
		set
		{
			if (value < 0 || value > 255)
				throw new ArgumentException("Each IP octet must be between 0 and 255");
			octets[index] = value;

		}
	}
	public override string ToString()
	{
		return $"{octets[0]}.{octets[1]}.{octets[2]}.{octets[3]}";
	}
}