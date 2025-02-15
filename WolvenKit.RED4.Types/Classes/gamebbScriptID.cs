using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamebbScriptID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("None")] 
		public gamebbID None
		{
			get => GetPropertyValue<gamebbID>();
			set => SetPropertyValue<gamebbID>(value);
		}

		public gamebbScriptID()
		{
			None = new();
		}
	}
}
