﻿namespace Fumbbl.Model
{
    public interface IModelUpdater
    {
        void Apply(Dto.IModelChange modelChange);
    }
}