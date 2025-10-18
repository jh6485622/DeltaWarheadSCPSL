using System;
using GameCore;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using MEC;
using UnityEngine;

namespace Delta
{
	// Token: 0x02000003 RID: 3
	public class Plugin : Plugin<Config>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002114 File Offset: 0x00000314
		public override string Name
		{
			get
			{
				return "Delta核弹";
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000211B File Offset: 0x0000031B
		public override string Description
		{
			get
			{
				return "Delta核弹";
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002122 File Offset: 0x00000322
		public override string Author
		{
			get
			{
				return "JH Blur";
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002129 File Offset: 0x00000329
		public override System.Version Version
		{
			get
			{
				return new System.Version(1, 0);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002132 File Offset: 0x00000332
		public override System.Version RequiredApiVersion
		{
			get
			{
				return new System.Version(LabApiProperties.CompiledVersion);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000213E File Offset: 0x0000033E
		public override void Enable()
		{
			CustomHandlersManager.RegisterEventsHandler<Events>(this._events);
			GameCore.Console.AddLog(this.Name + "插件已启动", Color.blue, false, GameCore.Console.ConsoleLogType.Log);
			Plugin.Status = this;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000216D File Offset: 0x0000036D
		public override void Disable()
		{
			CustomHandlersManager.UnregisterEventsHandler<Events>(this._events);
		}

		// Token: 0x04000001 RID: 1
		private readonly Events _events = new Events();

		// Token: 0x04000002 RID: 2
		public static CoroutineHandle DeltaCor;

		// Token: 0x04000003 RID: 3
		public static Plugin Status;
	}
}
