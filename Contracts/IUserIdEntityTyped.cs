using Common.Entities.Models;

namespace Common.Entities.I32.Contracts
{
	public interface IUserIdEntityTyped : IUserIdEntity<int>, IIdEntityTyped
	{ }
}