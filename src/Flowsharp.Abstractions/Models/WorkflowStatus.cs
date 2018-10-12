﻿namespace Flowsharp.Models
{
    public enum WorkflowStatus
    {
        Idle,
        Starting,
        Resuming,
        Executing,
        Halted,
        Finished,
        Faulted,
        Aborted
    }
}
