namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record NonConformanceLogGetRequestByGuidDTO(Guid guid);
    public  record NonConformanceLogGetRequestByIdDTO(String EntityNameId);
    public  record NonConformanceLogGetRequestDTO(Object EntityNameId);
    public  record NonConformanceLogCreateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  batcNo, string  stage, DateTime  whenItOccurred, string  defectName, string  logByUserName, string  status, string  solution, DateTime  whenItWasResolved, string  resolvedByUserName, string  comment, Guid  guidId );
    public  record NonConformanceLogUpdateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  batcNo, string  stage, DateTime  whenItOccurred, string  defectName, string  logByUserName, string  status, string  solution, DateTime  whenItWasResolved, string  resolvedByUserName, string  comment, Guid  guidId);
    public  record NonConformanceLogDeleteRequestDTO(Guid guid);
}