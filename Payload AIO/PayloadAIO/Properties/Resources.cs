using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PayloadAIO.Properties
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000050CE File Offset: 0x000032CE
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000050D8 File Offset: 0x000032D8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Payload_ELF_Injector.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005120 File Offset: 0x00003320
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00005137 File Offset: 0x00003337
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000043 RID: 67
		private static ResourceManager resourceMan;

		// Token: 0x04000044 RID: 68
		private static CultureInfo resourceCulture;
	}
}
