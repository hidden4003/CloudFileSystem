﻿using System.Threading.Tasks;

namespace NutzCode.CloudFileSystem
{

    public interface IFileSystem : IDirectory
    {
        string GetUserAuthorization();
        Task<FileSystemResult<IObject>> FromPath(string path);
        FileSystemSizes Sizes { get; }
        SupportedFlags Supports { get; }
    }
}
