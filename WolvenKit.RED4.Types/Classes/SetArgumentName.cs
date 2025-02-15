using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetArgumentName : SetArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CName CustomVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
