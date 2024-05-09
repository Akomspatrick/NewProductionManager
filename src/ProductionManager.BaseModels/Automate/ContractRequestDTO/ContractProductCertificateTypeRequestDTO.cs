namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductCertificateTypeGetRequestByGuidDTO(Guid guid);
    public  record ProductCertificateTypeGetRequestByIdDTO(String EntityNameId);
    public  record ProductCertificateTypeGetRequestDTO(Object EntityNameId);
    public  record ProductCertificateTypeCreateRequestDTO(string  certifcateType, string  description, Guid  guidId );
    public  record ProductCertificateTypeUpdateRequestDTO(string  certifcateType, string  description, Guid  guidId);
    public  record ProductCertificateTypeDeleteRequestDTO(Guid guid);
}