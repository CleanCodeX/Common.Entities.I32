using Common.Entities.I32.Contracts;
using Common.Entities.Models.Bases;

namespace Common.Entities.I32.Bases
{
	/// <inheritdoc />
	public abstract record IdEntityBase : IdEntityBase<int>, IIdEntityTyped
	{ }
}