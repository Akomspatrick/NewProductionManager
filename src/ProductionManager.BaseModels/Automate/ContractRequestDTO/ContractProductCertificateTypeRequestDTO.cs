namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductCertificateTypeGetRequestByGuidDTO(Guid guid);
    public  record ProductCertificateTypeGetRequestByIdDTO(String ObjectNameId);
    public  record ProductCertificateTypeGetRequestDTO(Object Value);
    public  record ProductCertificateTypeCreateRequestDTO(string  certifcateType, string  description, Guid  guidId );
    public  record ProductCertificateTypeUpdateRequestDTO(string  certifcateType, string  description, Guid  guidId);
    public  record ProductCertificateTypeDeleteRequestDTO(Guid guid);
}