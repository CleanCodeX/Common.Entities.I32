using Common.Entities.Models;

namespace Common.Entities.I32
{
	/// <inheritdoc cref="IContextEntity" />
	/// <inheritdoc cref="IIdEntityTyped" />
	public interface IContextEntityTyped : IContextEntity<int>, IIdEntityTyped
	{ }
}