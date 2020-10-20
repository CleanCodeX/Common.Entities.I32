using Common.Entities.Models.Bases;

namespace Common.Entities.I32.Bases
{
	/// <inheritdoc />
	public abstract partial record TextEntityBase : TextEntityBase<int>, ITextEntityTyped
	{ }
}
