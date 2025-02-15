using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNodeSourceChannel_WeightedVector : ISerializable
	{
		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> Channel
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNodeSourceChannel_WeightedVector()
		{
			Weight = 1.000000F;
			WeightLink = new();
			WeightFloatTrack = new();
		}
	}
}
