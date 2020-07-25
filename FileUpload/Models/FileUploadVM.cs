using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models
{
    public class FileUploadVM
    {
        public List<FileOnFileSystemModel> FilesOnFileSystem { get; set; } = new List<FileOnFileSystemModel>();
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; } = new List<FileOnDatabaseModel>();
    }
}
