using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;

namespace AspNetCoreStorage.Controllers
{
    public class BlobsController : Controller
    {
       
        public ActionResult CreateBlobContainer()
        {
            CloudBlobContainer container = GetCloudBlobContainer();
            ViewBag.Success = container.CreateIfNotExistsAsync().Result;
            ViewBag.BlobContainerName = container.Name;
            return View();
        }
        private CloudBlobContainer GetCloudBlobContainer() {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration Configuration = builder.Build();
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Configuration["ConnectionStrings:Zafulappstorage"]);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudFileClient file = storageAccount.CreateCloudFileClient();
            CloudBlobContainer container = blobClient.GetContainerReference("test-blob-container");
            return container;

        }

        public string UploadBlob(string filename, string imagepath) {
            CloudBlobContainer container = GetCloudBlobContainer();
            CloudBlockBlob blob = container.GetBlockBlobReference(filename);
            blob.Properties.ContentType = "image/png";

            using (var fileStream = System.IO.File.OpenRead(imagepath))
            {
                blob.UploadFromStreamAsync(fileStream).Wait();
            }
            return "success!";
        }
        public ActionResult ListBlobs()
        {
            CloudBlobContainer container = GetCloudBlobContainer();
            List<string> blobs = new List<string>();
            BlobResultSegment resultSegment = container.ListBlobsSegmentedAsync(null).Result;
            foreach (IListBlobItem item in resultSegment.Results) {
                if (item.GetType() == typeof(CloudBlockBlob)) {
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    blobs.Add(blob.Name);
                    blobs.Add(blob.Uri.AbsoluteUri.ToString());

                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    CloudPageBlob blob = (CloudPageBlob)item;
                    blobs.Add(blob.Name);
                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    CloudBlobDirectory dir = (CloudBlobDirectory)item;
                    blobs.Add(dir.Uri.ToString());
                }
            }
            return View(blobs);
        }
    }
}