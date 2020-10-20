using Common.Entities.Models;

namespace Common.Entities.I32.Contracts
{
	/// <inheritdoc cref="IContextIdEntity{Guid, Guid}" />
	/// <inheritdoc cref="IContextEntityTyped" />
	public interface IContextIdEntityTyped : IContextIdEntity<int, int>, IContextEntityTyped
	{ }
}