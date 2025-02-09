using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetPropertyValue<ReflectorSFX>();
			set => SetPropertyValue<ReflectorSFX>(value);
		}

		public BlindingLightControllerPS()
		{
			DeviceName = "LocKey#168";
			TweakDBRecord = new() { Value = 83448043739 };
			TweakDBDescriptionRecord = new() { Value = 137244048802 };
			ReflectorSFX = new() { Distraction = "dev_reflector_distraction", TurnOn = "dev_reflector_turn_on_loop", TurnOff = "dev_reflector_turn_on_loop_stop" };
		}
	}
}
