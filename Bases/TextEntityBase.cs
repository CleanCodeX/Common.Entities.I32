using Common.Entities.I32.Contracts;
using Common.Entities.Models.Bases;

namespace Common.Entities.I32.Bases.I32
{
	/// <inheritdoc />
	public abstract partial record TextEntityBase : TextEntityBase<int>, ITextEntityTyped
	{ }
}
