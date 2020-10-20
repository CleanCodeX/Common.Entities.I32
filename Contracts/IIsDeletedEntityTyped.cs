using Common.Entities.Models;

namespace Common.Entities.I32.Contracts
{
	/// <inheritdoc cref="IIsDeletedEntity" />
	/// <inheritdoc cref="IModifiedAtEntityTyped" />
	public interface IIsDeletedEntityTyped : IIsDeletedEntity<int>, IModifiedAtEntityTyped
	{ }
}