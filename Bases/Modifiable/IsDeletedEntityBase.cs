﻿using Common.Entities.Models.Bases.Modifiable;

namespace Common.Entities.I32.Bases.Modifiable
{
	/// <inheritdoc />
	public abstract record IsDeletedEntityBase : IsDeletedEntityBase<int>, IIsDeletedEntityTyped
	{ }
}