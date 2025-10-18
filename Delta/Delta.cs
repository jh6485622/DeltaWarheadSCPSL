using System;
using CustomPlayerEffects;
using LabApi.Features.Wrappers;
using MapGeneration;
using MEC;
using UnityEngine;

namespace Delta
{
	public class Delta
	{
		public static void Start()
		{
			Delta.IsDeltaStarted = true;
			if (Delta.IsDeltaStarted)
			{
				Cassie.Message(Plugin.Status.Config.DeltaCassie ?? "", false, false, true, "");
				Map.SetColorOfLights(Color.yellow);
				Timing.CallDelayed(90f, () =>
				{
					if (Delta.IsDeltaStarted)
					{
						Warhead.Shake();
						foreach (Player item in Player.List)
						{
							if (item.Zone == FacilityZone.HeavyContainment || item.Zone == FacilityZone.Entrance)
							{
								item.Kill("You are evaporated in Delta Warhead");
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

		public static void Stop()
		{
			if (Delta.IsDeltaStarted)
			{
				Delta.IsDeltaStarted = false;
			}
			Map.ResetColorOfLights();
			Cassie.Message("DELTA Warhead Stoped", false, false, true, "");
		}
	}
}
