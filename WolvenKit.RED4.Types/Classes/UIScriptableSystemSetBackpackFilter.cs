using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableSystemSetBackpackFilter : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("filterMode")] 
		public CInt32 FilterMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
