using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ButtonHints : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("horizontalHolder")] 
		public inkCompoundWidgetReference HorizontalHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public ButtonHints()
		{
			HorizontalHolder = new();
		}
	}
}
