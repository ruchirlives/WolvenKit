using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Stance : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
