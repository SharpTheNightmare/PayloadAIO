using System;
using System.Windows.Forms;

namespace PayloadAIO
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000050B3 File Offset: 0x000032B3
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Tool());
		}
	}
}
