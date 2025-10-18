using System;
using System.Collections.Generic;
using LabApi.Events.Arguments.WarheadEvents;
using LabApi.Events.CustomHandlers;
using LabApi.Features.Wrappers;
using MEC;
using PlayerRoles;

namespace Delta
{
	// Token: 0x02000002 RID: 2
	public class Events : CustomEventsHandler
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public override void OnServerRoundStarted()
		{
			Plugin.DeltaCor = Timing.RunCoroutine(this.StartDelta());
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public override void OnWarheadStarting(WarheadStartingEventArgs ev)
		{
			if (ev.IsAutomatic || ev.Player == null)
			{
				return;
			}
			foreach (Player item in Player.List)
			{
				if (ev.Player.Role == item.Role && item.Role == RoleTypeId.Tutorial && Plugin.Status.Config.GOCDelta)
				{
					Warhead.Stop(null);
					if (!ev.WarheadState.InProgress)
					{
						Delta.Start();
					}
					else
					{
						Delta.Stop();
					}
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
		private IEnumerator<float> StartDelta()
		{
			return new Events.<StartDelta>d__2(0);
		}
	}
}
