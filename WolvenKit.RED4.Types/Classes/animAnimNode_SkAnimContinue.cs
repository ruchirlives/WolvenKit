using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(31)] 
		[RED("popSafeCutTag")] 
		public CName PopSafeCutTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkAnimContinue()
		{
			Input = new();
		}
	}
}
