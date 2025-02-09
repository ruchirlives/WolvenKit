using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRenderScanEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("scanState")] 
		public CEnum<rendPostFx_ScanningState> ScanState
		{
			get => GetPropertyValue<CEnum<rendPostFx_ScanningState>>();
			set => SetPropertyValue<CEnum<rendPostFx_ScanningState>>(value);
		}
	}
}
