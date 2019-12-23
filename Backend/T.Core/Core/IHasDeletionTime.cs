using System;

namespace T.Core
{
    interface IHasDeletionTime: ISoftDelete
    {
        DateTime? DeletionTime { get; set; }
    }
}
