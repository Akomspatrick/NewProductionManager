namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductPictureGetRequestByGuidDTO(Guid guid);
    public  record ProductPictureGetRequestByIdDTO(String ObjectNameId);
    public  record ProductPictureGetRequestDTO(Object Value);
    public  record ProductPictureCreateRequestDTO(Int32  productId, DateTime  timestamp, string  userName, string  stage, string  fileName, string  localPathName, string  basePath, string  description, Guid  guidId );
    public  record ProductPictureUpdateRequestDTO(Int32  productId, DateTime  timestamp, string  userName, string  stage, string  fileName, string  localPathName, string  basePath, string  description, Guid  guidId);
    public  record ProductPictureDeleteRequestDTO(Guid guid);
}