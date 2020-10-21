using System;
using Common.Entities.Models.ListEntries;

namespace Common.Entities.I32.ListEntries
{
	/// <inheritdoc />
    public abstract record ListDependencyBase : ListDependencyBase<int>, IListDependencyTyped
    { }

	/// <inheritdoc />
	public abstract record ListDependencyBase<TParent, TChild> : ListDependencyBase<TParent, TChild, int>, IListDependencyWithTypesTyped
		where TParent : ListEntryBase<int>
		where TChild : ListEntryBase<int>
	{ }
}