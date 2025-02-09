using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBloodPuddleSettingsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetBloodPuddleSettingsEvent()
		{
			ShouldSpawnBloodPuddle = true;
		}
	}
}
