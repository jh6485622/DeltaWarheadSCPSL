using System;
using System.ComponentModel;

namespace Delta
{
	// Token: 0x02000005 RID: 5
	public class Config
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002231 File Offset: 0x00000431
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002239 File Offset: 0x00000439
		public bool IsEnabled { get; set; } = true;

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002242 File Offset: 0x00000442
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000224A File Offset: 0x0000044A
		[Description("回合开始后多少分钟后启动Delta核弹")]
		public float StartTime { get; set; } = 10f;

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002253 File Offset: 0x00000453
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000225B File Offset: 0x0000045B
		[Description("核弹启动时的广播")]
		public string DeltaCassie { get; set; } = "By order of O5 command.Dead Man Delta sequence activated";

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000226C File Offset: 0x0000046C
		[Description("GOC-Delta开核")]
		public bool GOCDelta { get; set; } = true;
	}
}
