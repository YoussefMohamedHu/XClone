﻿namespace XClone.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        
        Task<int> CompleteAsync();
    }
}
