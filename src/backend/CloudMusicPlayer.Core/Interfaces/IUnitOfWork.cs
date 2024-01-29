﻿using CloudMusicPlayer.Core.Interfaces.Repositories;

namespace CloudMusicPlayer.Core.Interfaces;

public interface IUnitOfWork
{
    public IUserRepository UserRepository { get; }
    public IPlaylistItemRepository PlaylistItemRepository { get; }
    public IDataProviderRepository DataProviderRepository { get; }
    public IMusicFileRepository MusicFileRepository { get; }
    public IPlaylistRepository PlaylistRepository { get; }
    public Task CommitAsync();
}
