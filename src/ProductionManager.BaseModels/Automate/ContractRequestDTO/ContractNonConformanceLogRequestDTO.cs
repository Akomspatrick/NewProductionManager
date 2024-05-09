namespace ProductionManager.Contracts.RequestDTO
{
    public  record NonConformanceLogGetRequestByGuidDTO(Guid guid);
    public  record NonConformanceLogGetRequestByIdDTO(String ObjectNameId);
    public  record NonConformanceLogGetRequestDTO(Object Value);
    public  record NonConformanceLogCreateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  batcNo, string  stage, DateTime  whenItOccurred, string  defectName, string  logByUserName, string  status, string  solution, DateTime  whenItWasResolved, string  resolvedByUserName, string  comment, Guid  guidId );
    public  record NonConformanceLogUpdateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  batcNo, string  stage, DateTime  whenItOccurred, string  defectName, string  logByUserName, string  status, string  solution, DateTime  whenItWasResolved, string  resolvedByUserName, string  comment, Guid  guidId);
    public  record NonConformanceLogDeleteRequestDTO(Guid guid);
}