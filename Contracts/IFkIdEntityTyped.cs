using Common.Entities.Models;

namespace Common.Entities.I32.Contracts
{
    /// <inheritdoc />
    public interface IHasFkIdTyped : IHasFkId<int> 
    { }

    /// <inheritdoc />
    public interface IFkIdEntityTyped : IFkIdEntity<int, int>, IHasFkIdTyped, IIdEntityTyped
    { }
}