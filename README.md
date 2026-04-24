# FileUploader
This Project based on [Azure-Samples](https://github.com/Azure-Samples/storage-blob-upload-from-webapp), many thanks for samples.

File Uploader project allow to upload images to Azure Storage account via simple web application.
The design, compared to the original sources, includes minor modifications used in private projects.

## App Permissions
For security reasons, App Services must authenticate with the Storage Account using Managed Identity. This requires granting Storage Account permissions at the Storage Blob Data Contributor level for App Services identity.
