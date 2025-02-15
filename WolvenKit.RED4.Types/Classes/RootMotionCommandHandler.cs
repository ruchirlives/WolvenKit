using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RootMotionCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("params")] 
		public CHandle<AIArgumentMapping> Params
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
