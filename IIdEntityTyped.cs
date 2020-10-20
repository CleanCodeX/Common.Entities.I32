using Common.Entities.Models;

namespace Common.Entities.I32
{
	/// <inheritdoc />
	public interface IHasIdTyped : IHasId<int>
	{ }

	/// <inheritdoc />
	public interface IIdEntityTyped: IIdEntity<int>, IHasIdTyped
	{ }
}