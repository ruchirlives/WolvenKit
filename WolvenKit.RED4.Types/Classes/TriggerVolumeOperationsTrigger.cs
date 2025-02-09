using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerVolumeOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<TriggerVolumeOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<TriggerVolumeOperationTriggerData>>();
			set => SetPropertyValue<CHandle<TriggerVolumeOperationTriggerData>>(value);
		}
	}
}
