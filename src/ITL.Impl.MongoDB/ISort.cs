﻿namespace ITL.Impl.MongoDB
{
    public interface ISort
    {
        string PropertyName { get; set; }

        bool Ascending { get; set; }
    }
}
