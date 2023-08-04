using System;

namespace Your_First_Pasted_Spoofer
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002108 File Offset: 0x00000308
		private static void Main(string[] args)
		{
			Console.Title = "DarkWare V1 SPOOFER #BACK";
			Misc.DrawASCII();
			Misc.HashText("Welcome to DarkWare V1 SPOOFER #BACK");
			Misc.HashText("Press any key to load options...");
			Console.ReadKey();
			Console.Clear();
			Misc.DrawASCII();
			Misc.OptionText("Spoof");
			Misc.OptionText("Clean");
			Misc.HashText("Option : ");
			string a = Console.ReadLine();
			if (a == "1")
			{
				Console.Clear();
				Misc.DrawASCII();
				Misc.HashText("Spoofing Diskdrive!");
				Spoof.SpoofHDD();
				Misc.HashText("Spoofed Diskdrive!");
				Console.ReadKey();
				return;
			}
			if (a == "2")
			{
				Console.Clear();
				Misc.DrawASCII();
				Misc.HashText("Cleaning Traces!");
				Spoof.CleanTraces("C:\\Windows\\IME\\cleaner.exe");
				Misc.HashText("Cleaned Traces!");
				Console.ReadKey();
				return;
			}
			Misc.HashText("Ok retard maybe type right next time");
		}
	}
}
