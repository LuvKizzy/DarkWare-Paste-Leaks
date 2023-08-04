using System;

namespace Your_First_Pasted_Spoofer
{
	// Token: 0x02000002 RID: 2
	internal class Misc
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void DrawASCII()
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("DarkWare V1 Spoofer #back");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public static void HashText(string text)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("#");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("] ");
			Console.Write(text);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A4 File Offset: 0x000002A4
		public static void OptionText(string text)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.White;
			Misc.number++;
			Console.Write(Misc.number);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("] ");
			Console.Write(text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020F6 File Offset: 0x000002F6
		private static void ResetOption()
		{
			Misc.number = 0;
		}

		// Token: 0x04000001 RID: 1
		private static int number;
	}
}
