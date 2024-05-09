namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductGetRequestByGuidDTO(Guid guid);
    public  record ProductGetRequestByIdDTO(String EntityNameId);
    public  record ProductGetRequestDTO(Object EntityNameId);
    public  record ProductCreateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  capacity, DateTime  timestamp, string  stage, string  subStage, string  invoiceId, string  salesOrderId, Int32  cableLength, Int32  inspectionResult, string  defaultTestingMode, string  modelTypeGroupName, string  usedTestingMode, string  thermexPurcharseOrderNo, string  machiningPurcharseOrderNo, string  steelPurcharseOrderNo, Int32  batcNo, string  loadDirection, Guid  guidId );
    public  record ProductUpdateRequestDTO(Int32  productId, Int32  modelVersionId, string  modelName, Int32  capacity, DateTime  timestamp, string  stage, string  subStage, string  invoiceId, string  salesOrderId, Int32  cableLength, Int32  inspectionResult, string  defaultTestingMode, string  modelTypeGroupName, string  usedTestingMode, string  thermexPurcharseOrderNo, string  machiningPurcharseOrderNo, string  steelPurcharseOrderNo, Int32  batcNo, string  loadDirection, Guid  guidId);
    public  record ProductDeleteRequestDTO(Guid guid);
}