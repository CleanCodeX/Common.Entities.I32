using Common.Entities.Models.ListEntries;

namespace Common.Entities.I32.ListEntries
{
	/// <inheritdoc />
	public interface IListEntryTyped: IListEntry<int>, IHasIdTyped
	{ }
}