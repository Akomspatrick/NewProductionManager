namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductPictureGetRequestByGuidDTO(Guid guid);
    public  record ProductPictureGetRequestByIdDTO(String EntityNameId);
    public  record ProductPictureGetRequestDTO(Object EntityNameId);
    public  record ProductPictureCreateRequestDTO(Int32  productId, DateTime  timestamp, string  userName, string  stage, string  fileName, string  localPathName, string  basePath, string  description, Guid  guidId );
    public  record ProductPictureUpdateRequestDTO(Int32  productId, DateTime  timestamp, string  userName, string  stage, string  fileName, string  localPathName, string  basePath, string  description, Guid  guidId);
    public  record ProductPictureDeleteRequestDTO(Guid guid);
}