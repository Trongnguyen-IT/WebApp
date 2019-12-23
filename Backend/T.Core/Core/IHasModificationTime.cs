using System;

namespace T.Core
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
