using Common.Entities.I32.Contracts;
using Common.Entities.Models.Bases.Modifiable;

namespace Common.Entities.I32.Bases.Modifiable
{
	/// <inheritdoc />
	public abstract record ContextEntityBase : ContextEntityBase<int, int>, IContextEntityTyped
	{ }
}