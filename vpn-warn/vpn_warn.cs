using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace vpnwarn
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces ();
				Boolean found = false;
				foreach (NetworkInterface adapter in adapters) {
					if (adapter.Description.Contains ("ppp")) {
						found = true;
						break;
					}
				}
				if (!found) {
					Console.WriteLine("vpn disconnect");
				}
				Thread.Sleep (5000);
			}
		}
	}
}
