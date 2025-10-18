using System;
using CustomPlayerEffects;
using LabApi.Features.Wrappers;
using MapGeneration;
using MEC;
using UnityEngine;

namespace Delta
{
	// Token: 0x02000004 RID: 4
	public class Delta
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002190 File Offset: 0x00000390
		public static void Start()
		{
			Delta.IsDeltaStarted = true;
			if (Delta.IsDeltaStarted)
			{
				Cassie.Message(Plugin.Status.Config.DeltaCassie ?? "", false, false, true, "");
				Map.SetColorOfLights(Color.yellow);
				Timing.CallDelayed(90f, delegate()
				{
					if (Delta.IsDeltaStarted)
					{
						Warhead.Shake();
						foreach (Player item in Player.List)
						{
							if (item.Zone == FacilityZone.HeavyContainment || item.Zone == FacilityZone.Entrance)
							{
								item.Kill("你在Delta核弹头中蒸发了", "");
							}
							else
							{
								item.EnableEffect<Blurred>(1, 0f, false);
							}
						}
						Map.SetColorOfLights(Color.clear);
					}
				});
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002203 File Offset: 0x00000403
		public static void Stop()
		{
			if (Delta.IsDeltaStarted)
			{
				Delta.IsDeltaStarted = false;
			}
			Map.ResetColorOfLights();
			Cassie.Message("DELTA核弹头已终止", false, false, true, "");
		}

		// Token: 0x04000004 RID: 4
		public static bool IsDeltaStarted;
	}
}
