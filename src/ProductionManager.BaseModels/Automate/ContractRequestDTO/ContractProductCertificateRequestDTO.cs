namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductCertificateGetRequestByGuidDTO(Guid guid);
    public  record ProductCertificateGetRequestByIdDTO(String EntityNameId);
    public  record ProductCertificateGetRequestDTO(Object EntityNameId);
    public  record ProductCertificateCreateRequestDTO(Int32  productCertificateId, Int32  productId, string  certifcateType, string  jsonData, DateTime  timestamp, Int32  capacity, Guid  guidId );
    public  record ProductCertificateUpdateRequestDTO(Int32  productCertificateId, Int32  productId, string  certifcateType, string  jsonData, DateTime  timestamp, Int32  capacity, Guid  guidId);
    public  record ProductCertificateDeleteRequestDTO(Guid guid);
}