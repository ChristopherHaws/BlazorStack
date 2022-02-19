namespace BlazorStack;

/// <summary>
/// Defines how the browser distributes space between and around content items
/// </summary>
public enum StackAlignment {
	/// <summary>
	/// The items are packed flush to each other toward the start
	/// edge of the alignment container in the main axis.
	/// </summary>
	Start,

	/// <summary>
	/// The items are packed flush to each other toward the end edge
	/// of the alignment container in the main axis.
	/// </summary>
	End,

	/// <summary>
	/// The items are packed flush to each other toward the center of
	/// the alignment container along the main axis.
	/// </summary>
	Centered,

	/// <summary>
	/// The items are evenly distributed within the alignment container along the main axis.
	/// The spacing between each pair of adjacent items is the same. The empty space before the
	/// first and after the last item equals half of the space between each pair of adjacent items.
	/// </summary>
	SpaceAround,

	/// <summary>
	/// The items are evenly distributed within the alignment container along the main axis.
	/// The spacing between each pair of adjacent items is the same. The first item is flush
	/// with the main-start edge, and the last item is flush with the main-end edge.
	/// </summary>
	SpaceBetween,

	/// <summary>
	/// The items are evenly distributed within the alignment container along the main axis.
	/// The spacing between each pair of adjacent items, the main-start edge and the first item,
	/// and the main-end edge and the last item, are all exactly the same.
	/// </summary>
	Even,

	/// <summary>
	/// If the combined size of the items along the main axis is less than the size of the alignment
	/// container, any auto-sized items have their size increased equally (not proportionally), while
	/// still respecting the constraints imposed by max-height/max-width (or equivalent functionality),
	/// so that the combined size exactly fills the alignment container along the main axis.
	/// </summary>
	Stretch,

	/// <summary>
	/// Specifies participation in first- or last-baseline alignment:
	/// aligns the alignment baseline of the box's first or last baseline
	/// set with the corresponding baseline in the shared first or last
	/// baseline set of all the boxes in its baseline-sharing group.
	/// The fallback alignment for first baseline is start, the one
	/// for last baseline is end.
	/// </summary>
	Baseline
}
