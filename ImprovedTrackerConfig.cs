class ImprovedTrackerConfig
{
	public bool Berries { get; set; }
	public bool CoconutTrees { get; set; }
	public bool FishingSpots { get; set; }
	public bool Underground { get; set; }
	public bool SeedSpots { get; set; }

	public ImprovedTrackerConfig()
	{
		Berries = true;
		CoconutTrees = true;
		FishingSpots = true;
		Underground = true;
		SeedSpots = true;
	}
}