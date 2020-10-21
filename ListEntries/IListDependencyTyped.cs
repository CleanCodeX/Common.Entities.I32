using Common.Entities.Models.ListEntries;

namespace Common.Entities.I32.ListEntries
{
	/// <inheritdoc />
	public interface IHasDependencyIdsTyped : IHasDependencyIds<int>
	{ }

	/// <inheritdoc />
	public interface IListDependencyTyped : IHasDependencyIdsTyped, IHasIdTyped
	{ }

	/// <inheritdoc />
	public interface IListDependencyWithTypesTyped : IListDependencyWithTypes<int>, IListDependencyTyped
	{ }
}