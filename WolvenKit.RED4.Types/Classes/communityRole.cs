using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityRole : ISerializable
	{
		[Ordinal(0)] 
		[RED("roleName")] 
		public CName RoleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communityRole()
		{
			RoleName = "default";
		}
	}
}
