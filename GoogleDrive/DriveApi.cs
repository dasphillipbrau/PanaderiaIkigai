using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PanaderiaIkigai.GoogleDrive
{
    public class DriveApi
    {
        static string[] Scopes = { DriveService.Scope.DriveFile };
        static string ApplicationName = "Ikigai";

        public static string BackupDatabase(string pFilePath)
        {
            var credential = GetCredentials();
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            
            string folderName = "Ikigai-Backups";

            FilesResource.ListRequest request = service.Files.List();
            request.Q = "mimeType = 'application/vnd.google-apps.folder' and name='Ikigai-Backups'";
            var result = request.Execute();
            string folderId = result.Files.Count == 0 ? null : result.Files[0].Id;
            if(folderId == null)
            {
                folderId = CreateFolder(folderName, service);
                
            }
            return CreateFile(pFilePath, folderId, service);
        }

        private static string CreateFile(string pFilePath, string parentFolderId, DriveService service)
        {

                var fileMetaData = new Google.Apis.Drive.v3.Data.File();
                fileMetaData.Name = Path.GetFileName(pFilePath);
                fileMetaData.MimeType = "application/vnd.google-apps.file";
                fileMetaData.Parents = new List<string> { parentFolderId };
                FilesResource.CreateMediaUpload request;
                using(var stream = new FileStream(pFilePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetaData, stream, "application/vnd.google-apps.file");
                    request.Fields = "id";
                    request.Upload();
                }
                var file = request.ResponseBody;
                return file.Id;
        }
        private static string CreateFolder(string pFolderName, DriveService service)
        {
            var fileMetaData = new Google.Apis.Drive.v3.Data.File()
            {
                Name = pFolderName,
                MimeType = "application/vnd.google-apps.folder"
            };
            var request = service.Files.Create(fileMetaData);
            request.Fields = "id";
            var file = request.Execute();
            return file.Id;

        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using(var stream = new FileStream("./GoogleDrive/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "./GoogleDrive/token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
               System.Diagnostics.Debug.WriteLine("Credential file saved to: " + credPath);
            }
            return credential;
        }
    }
}
