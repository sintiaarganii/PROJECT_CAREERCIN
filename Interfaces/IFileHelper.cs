﻿namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IFileHelper
    {
        Task<string> UploadPdfAsync(IFormFile file, string folderName);
        Task<byte[]> DownloadFileAsync(string fileName, string folderName);
    }
}
