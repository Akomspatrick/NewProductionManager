namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductCertificateGetRequestByGuidDTO(Guid guid);
    public  record ProductCertificateGetRequestByIdDTO(String ObjectNameId);
    public  record ProductCertificateGetRequestDTO(Object Value);
    public  record ProductCertificateCreateRequestDTO(Int32  productCertificateId, Int32  productId, string  certifcateType, string  jsonData, DateTime  timestamp, Int32  capacity, Guid  guidId );
    public  record ProductCertificateUpdateRequestDTO(Int32  productCertificateId, Int32  productId, string  certifcateType, string  jsonData, DateTime  timestamp, Int32  capacity, Guid  guidId);
    public  record ProductCertificateDeleteRequestDTO(Guid guid);
}