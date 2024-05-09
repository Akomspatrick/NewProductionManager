using AutoMapper;
using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.RequestDTO.V1.auto;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // AmplifierBoard Mappings 
            //CreateMap<AmplifierBoardGetRequestDTO, AmplifierBoard>().ReverseMap();
            //CreateMap<AmplifierBoardGetRequestByIdDTO, AmplifierBoard>().ReverseMap();
            //CreateMap<AmplifierBoardGetRequestByGuidDTO, AmplifierBoard>().ReverseMap();
            //CreateMap<AmplifierBoardCreateRequestDTO, AmplifierBoard>().ReverseMap();
            CreateMap<AmplifierBoardUpdateRequestDTO, AmplifierBoard>().ReverseMap();
            //CreateMap<AmplifierBoardDeleteRequestDTO, AmplifierBoard>().ReverseMap();
        
            // DefectType Mappings 
            //CreateMap<DefectTypeGetRequestDTO, DefectType>().ReverseMap();
            //CreateMap<DefectTypeGetRequestByIdDTO, DefectType>().ReverseMap();
            //CreateMap<DefectTypeGetRequestByGuidDTO, DefectType>().ReverseMap();
            //CreateMap<DefectTypeCreateRequestDTO, DefectType>().ReverseMap();
            CreateMap<DefectTypeUpdateRequestDTO, DefectType>().ReverseMap();
            //CreateMap<DefectTypeDeleteRequestDTO, DefectType>().ReverseMap();
        
            // DefectTypeSolution Mappings 
            //CreateMap<DefectTypeSolutionGetRequestDTO, DefectTypeSolution>().ReverseMap();
            //CreateMap<DefectTypeSolutionGetRequestByIdDTO, DefectTypeSolution>().ReverseMap();
            //CreateMap<DefectTypeSolutionGetRequestByGuidDTO, DefectTypeSolution>().ReverseMap();
            //CreateMap<DefectTypeSolutionCreateRequestDTO, DefectTypeSolution>().ReverseMap();
            CreateMap<DefectTypeSolutionUpdateRequestDTO, DefectTypeSolution>().ReverseMap();
            //CreateMap<DefectTypeSolutionDeleteRequestDTO, DefectTypeSolution>().ReverseMap();
        
            // LogDetail Mappings 
            //CreateMap<LogDetailGetRequestDTO, LogDetail>().ReverseMap();
            //CreateMap<LogDetailGetRequestByIdDTO, LogDetail>().ReverseMap();
            //CreateMap<LogDetailGetRequestByGuidDTO, LogDetail>().ReverseMap();
            //CreateMap<LogDetailCreateRequestDTO, LogDetail>().ReverseMap();
            CreateMap<LogDetailUpdateRequestDTO, LogDetail>().ReverseMap();
            //CreateMap<LogDetailDeleteRequestDTO, LogDetail>().ReverseMap();
        
            // LogSummary Mappings 
            //CreateMap<LogSummaryGetRequestDTO, LogSummary>().ReverseMap();
            //CreateMap<LogSummaryGetRequestByIdDTO, LogSummary>().ReverseMap();
            //CreateMap<LogSummaryGetRequestByGuidDTO, LogSummary>().ReverseMap();
            //CreateMap<LogSummaryCreateRequestDTO, LogSummary>().ReverseMap();
            CreateMap<LogSummaryUpdateRequestDTO, LogSummary>().ReverseMap();
            //CreateMap<LogSummaryDeleteRequestDTO, LogSummary>().ReverseMap();
        
            // ModelVersion Mappings 
            //CreateMap<ModelVersionGetRequestDTO, ModelVersion>().ReverseMap();
            //CreateMap<ModelVersionGetRequestByIdDTO, ModelVersion>().ReverseMap();
            //CreateMap<ModelVersionGetRequestByGuidDTO, ModelVersion>().ReverseMap();
            //CreateMap<ModelVersionCreateRequestDTO, ModelVersion>().ReverseMap();
            CreateMap<ModelVersionUpdateRequestDTO, ModelVersion>().ReverseMap();
            //CreateMap<ModelVersionDeleteRequestDTO, ModelVersion>().ReverseMap();
        
            // NonConformanceLog Mappings 
            //CreateMap<NonConformanceLogGetRequestDTO, NonConformanceLog>().ReverseMap();
            //CreateMap<NonConformanceLogGetRequestByIdDTO, NonConformanceLog>().ReverseMap();
            //CreateMap<NonConformanceLogGetRequestByGuidDTO, NonConformanceLog>().ReverseMap();
            //CreateMap<NonConformanceLogCreateRequestDTO, NonConformanceLog>().ReverseMap();
            CreateMap<NonConformanceLogUpdateRequestDTO, NonConformanceLog>().ReverseMap();
            //CreateMap<NonConformanceLogDeleteRequestDTO, NonConformanceLog>().ReverseMap();
        
            // Product Mappings 
            //CreateMap<ProductGetRequestDTO, Product>().ReverseMap();
            //CreateMap<ProductGetRequestByIdDTO, Product>().ReverseMap();
            //CreateMap<ProductGetRequestByGuidDTO, Product>().ReverseMap();
            //CreateMap<ProductCreateRequestDTO, Product>().ReverseMap();
            CreateMap<ProductUpdateRequestDTO, Product>().ReverseMap();
            //CreateMap<ProductDeleteRequestDTO, Product>().ReverseMap();
        
            // ProductAdditionalInfo Mappings 
            //CreateMap<ProductAdditionalInfoGetRequestDTO, ProductAdditionalInfo>().ReverseMap();
            //CreateMap<ProductAdditionalInfoGetRequestByIdDTO, ProductAdditionalInfo>().ReverseMap();
            //CreateMap<ProductAdditionalInfoGetRequestByGuidDTO, ProductAdditionalInfo>().ReverseMap();
            //CreateMap<ProductAdditionalInfoCreateRequestDTO, ProductAdditionalInfo>().ReverseMap();
            CreateMap<ProductAdditionalInfoUpdateRequestDTO, ProductAdditionalInfo>().ReverseMap();
            //CreateMap<ProductAdditionalInfoDeleteRequestDTO, ProductAdditionalInfo>().ReverseMap();
        
            // ProductCablingEvent Mappings 
            //CreateMap<ProductCablingEventGetRequestDTO, ProductCablingEvent>().ReverseMap();
            //CreateMap<ProductCablingEventGetRequestByIdDTO, ProductCablingEvent>().ReverseMap();
            //CreateMap<ProductCablingEventGetRequestByGuidDTO, ProductCablingEvent>().ReverseMap();
            //CreateMap<ProductCablingEventCreateRequestDTO, ProductCablingEvent>().ReverseMap();
            CreateMap<ProductCablingEventUpdateRequestDTO, ProductCablingEvent>().ReverseMap();
            //CreateMap<ProductCablingEventDeleteRequestDTO, ProductCablingEvent>().ReverseMap();
        
            // ProductCertificate Mappings 
            //CreateMap<ProductCertificateGetRequestDTO, ProductCertificate>().ReverseMap();
            //CreateMap<ProductCertificateGetRequestByIdDTO, ProductCertificate>().ReverseMap();
            //CreateMap<ProductCertificateGetRequestByGuidDTO, ProductCertificate>().ReverseMap();
            //CreateMap<ProductCertificateCreateRequestDTO, ProductCertificate>().ReverseMap();
            CreateMap<ProductCertificateUpdateRequestDTO, ProductCertificate>().ReverseMap();
            //CreateMap<ProductCertificateDeleteRequestDTO, ProductCertificate>().ReverseMap();
        
            // ProductCertificateType Mappings 
            //CreateMap<ProductCertificateTypeGetRequestDTO, ProductCertificateType>().ReverseMap();
            //CreateMap<ProductCertificateTypeGetRequestByIdDTO, ProductCertificateType>().ReverseMap();
            //CreateMap<ProductCertificateTypeGetRequestByGuidDTO, ProductCertificateType>().ReverseMap();
            //CreateMap<ProductCertificateTypeCreateRequestDTO, ProductCertificateType>().ReverseMap();
            CreateMap<ProductCertificateTypeUpdateRequestDTO, ProductCertificateType>().ReverseMap();
            //CreateMap<ProductCertificateTypeDeleteRequestDTO, ProductCertificateType>().ReverseMap();
        
            // ProductFinalUnit Mappings 
            //CreateMap<ProductFinalUnitGetRequestDTO, ProductFinalUnit>().ReverseMap();
            //CreateMap<ProductFinalUnitGetRequestByIdDTO, ProductFinalUnit>().ReverseMap();
            //CreateMap<ProductFinalUnitGetRequestByGuidDTO, ProductFinalUnit>().ReverseMap();
            //CreateMap<ProductFinalUnitCreateRequestDTO, ProductFinalUnit>().ReverseMap();
            CreateMap<ProductFinalUnitUpdateRequestDTO, ProductFinalUnit>().ReverseMap();
            //CreateMap<ProductFinalUnitDeleteRequestDTO, ProductFinalUnit>().ReverseMap();
        
            // ProductFinalVerifiationEvent Mappings 
            //CreateMap<ProductFinalVerifiationEventGetRequestDTO, ProductFinalVerifiationEvent>().ReverseMap();
            //CreateMap<ProductFinalVerifiationEventGetRequestByIdDTO, ProductFinalVerifiationEvent>().ReverseMap();
            //CreateMap<ProductFinalVerifiationEventGetRequestByGuidDTO, ProductFinalVerifiationEvent>().ReverseMap();
            //CreateMap<ProductFinalVerifiationEventCreateRequestDTO, ProductFinalVerifiationEvent>().ReverseMap();
            CreateMap<ProductFinalVerifiationEventUpdateRequestDTO, ProductFinalVerifiationEvent>().ReverseMap();
            //CreateMap<ProductFinalVerifiationEventDeleteRequestDTO, ProductFinalVerifiationEvent>().ReverseMap();
        
            // ProductFinishedEvent Mappings 
            //CreateMap<ProductFinishedEventGetRequestDTO, ProductFinishedEvent>().ReverseMap();
            //CreateMap<ProductFinishedEventGetRequestByIdDTO, ProductFinishedEvent>().ReverseMap();
            //CreateMap<ProductFinishedEventGetRequestByGuidDTO, ProductFinishedEvent>().ReverseMap();
            //CreateMap<ProductFinishedEventCreateRequestDTO, ProductFinishedEvent>().ReverseMap();
            CreateMap<ProductFinishedEventUpdateRequestDTO, ProductFinishedEvent>().ReverseMap();
            //CreateMap<ProductFinishedEventDeleteRequestDTO, ProductFinishedEvent>().ReverseMap();
        
            // ProductGaugeInspectionEvent Mappings 
            //CreateMap<ProductGaugeInspectionEventGetRequestDTO, ProductGaugeInspectionEvent>().ReverseMap();
            //CreateMap<ProductGaugeInspectionEventGetRequestByIdDTO, ProductGaugeInspectionEvent>().ReverseMap();
            //CreateMap<ProductGaugeInspectionEventGetRequestByGuidDTO, ProductGaugeInspectionEvent>().ReverseMap();
            //CreateMap<ProductGaugeInspectionEventCreateRequestDTO, ProductGaugeInspectionEvent>().ReverseMap();
            CreateMap<ProductGaugeInspectionEventUpdateRequestDTO, ProductGaugeInspectionEvent>().ReverseMap();
            //CreateMap<ProductGaugeInspectionEventDeleteRequestDTO, ProductGaugeInspectionEvent>().ReverseMap();
        
            // ProductGaugeEvent Mappings 
            //CreateMap<ProductGaugeEventGetRequestDTO, ProductGaugeEvent>().ReverseMap();
            //CreateMap<ProductGaugeEventGetRequestByIdDTO, ProductGaugeEvent>().ReverseMap();
            //CreateMap<ProductGaugeEventGetRequestByGuidDTO, ProductGaugeEvent>().ReverseMap();
            //CreateMap<ProductGaugeEventCreateRequestDTO, ProductGaugeEvent>().ReverseMap();
            CreateMap<ProductGaugeEventUpdateRequestDTO, ProductGaugeEvent>().ReverseMap();
            //CreateMap<ProductGaugeEventDeleteRequestDTO, ProductGaugeEvent>().ReverseMap();
        
            // ProductInitialUnit Mappings 
            //CreateMap<ProductInitialUnitGetRequestDTO, ProductInitialUnit>().ReverseMap();
            //CreateMap<ProductInitialUnitGetRequestByIdDTO, ProductInitialUnit>().ReverseMap();
            //CreateMap<ProductInitialUnitGetRequestByGuidDTO, ProductInitialUnit>().ReverseMap();
            //CreateMap<ProductInitialUnitCreateRequestDTO, ProductInitialUnit>().ReverseMap();
            CreateMap<ProductInitialUnitUpdateRequestDTO, ProductInitialUnit>().ReverseMap();
            //CreateMap<ProductInitialUnitDeleteRequestDTO, ProductInitialUnit>().ReverseMap();
        
            // ProductInitialVerificationEvent Mappings 
            //CreateMap<ProductInitialVerificationEventGetRequestDTO, ProductInitialVerificationEvent>().ReverseMap();
            //CreateMap<ProductInitialVerificationEventGetRequestByIdDTO, ProductInitialVerificationEvent>().ReverseMap();
            //CreateMap<ProductInitialVerificationEventGetRequestByGuidDTO, ProductInitialVerificationEvent>().ReverseMap();
            //CreateMap<ProductInitialVerificationEventCreateRequestDTO, ProductInitialVerificationEvent>().ReverseMap();
            CreateMap<ProductInitialVerificationEventUpdateRequestDTO, ProductInitialVerificationEvent>().ReverseMap();
            //CreateMap<ProductInitialVerificationEventDeleteRequestDTO, ProductInitialVerificationEvent>().ReverseMap();
        
            // ProductInventoryEvent Mappings 
            //CreateMap<ProductInventoryEventGetRequestDTO, ProductInventoryEvent>().ReverseMap();
            //CreateMap<ProductInventoryEventGetRequestByIdDTO, ProductInventoryEvent>().ReverseMap();
            //CreateMap<ProductInventoryEventGetRequestByGuidDTO, ProductInventoryEvent>().ReverseMap();
            //CreateMap<ProductInventoryEventCreateRequestDTO, ProductInventoryEvent>().ReverseMap();
            CreateMap<ProductInventoryEventUpdateRequestDTO, ProductInventoryEvent>().ReverseMap();
            //CreateMap<ProductInventoryEventDeleteRequestDTO, ProductInventoryEvent>().ReverseMap();
        
            // ProductLabellingEvent Mappings 
            //CreateMap<ProductLabellingEventGetRequestDTO, ProductLabellingEvent>().ReverseMap();
            //CreateMap<ProductLabellingEventGetRequestByIdDTO, ProductLabellingEvent>().ReverseMap();
            //CreateMap<ProductLabellingEventGetRequestByGuidDTO, ProductLabellingEvent>().ReverseMap();
            //CreateMap<ProductLabellingEventCreateRequestDTO, ProductLabellingEvent>().ReverseMap();
            CreateMap<ProductLabellingEventUpdateRequestDTO, ProductLabellingEvent>().ReverseMap();
            //CreateMap<ProductLabellingEventDeleteRequestDTO, ProductLabellingEvent>().ReverseMap();
        
            // ProductMovingEvent Mappings 
            //CreateMap<ProductMovingEventGetRequestDTO, ProductMovingEvent>().ReverseMap();
            //CreateMap<ProductMovingEventGetRequestByIdDTO, ProductMovingEvent>().ReverseMap();
            //CreateMap<ProductMovingEventGetRequestByGuidDTO, ProductMovingEvent>().ReverseMap();
            //CreateMap<ProductMovingEventCreateRequestDTO, ProductMovingEvent>().ReverseMap();
            CreateMap<ProductMovingEventUpdateRequestDTO, ProductMovingEvent>().ReverseMap();
            //CreateMap<ProductMovingEventDeleteRequestDTO, ProductMovingEvent>().ReverseMap();
        
            // ProductPicture Mappings 
            //CreateMap<ProductPictureGetRequestDTO, ProductPicture>().ReverseMap();
            //CreateMap<ProductPictureGetRequestByIdDTO, ProductPicture>().ReverseMap();
            //CreateMap<ProductPictureGetRequestByGuidDTO, ProductPicture>().ReverseMap();
            //CreateMap<ProductPictureCreateRequestDTO, ProductPicture>().ReverseMap();
            CreateMap<ProductPictureUpdateRequestDTO, ProductPicture>().ReverseMap();
            //CreateMap<ProductPictureDeleteRequestDTO, ProductPicture>().ReverseMap();
        
            // ProductReceptionEvent Mappings 
            //CreateMap<ProductReceptionEventGetRequestDTO, ProductReceptionEvent>().ReverseMap();
            //CreateMap<ProductReceptionEventGetRequestByIdDTO, ProductReceptionEvent>().ReverseMap();
            //CreateMap<ProductReceptionEventGetRequestByGuidDTO, ProductReceptionEvent>().ReverseMap();
            //CreateMap<ProductReceptionEventCreateRequestDTO, ProductReceptionEvent>().ReverseMap();
            CreateMap<ProductReceptionEventUpdateRequestDTO, ProductReceptionEvent>().ReverseMap();
            //CreateMap<ProductReceptionEventDeleteRequestDTO, ProductReceptionEvent>().ReverseMap();
        
            // ProductResistorInstallationEvent Mappings 
            //CreateMap<ProductResistorInstallationEventGetRequestDTO, ProductResistorInstallationEvent>().ReverseMap();
            //CreateMap<ProductResistorInstallationEventGetRequestByIdDTO, ProductResistorInstallationEvent>().ReverseMap();
            //CreateMap<ProductResistorInstallationEventGetRequestByGuidDTO, ProductResistorInstallationEvent>().ReverseMap();
            //CreateMap<ProductResistorInstallationEventCreateRequestDTO, ProductResistorInstallationEvent>().ReverseMap();
            CreateMap<ProductResistorInstallationEventUpdateRequestDTO, ProductResistorInstallationEvent>().ReverseMap();
            //CreateMap<ProductResistorInstallationEventDeleteRequestDTO, ProductResistorInstallationEvent>().ReverseMap();
        
            // ProductSealingEvent Mappings 
            //CreateMap<ProductSealingEventGetRequestDTO, ProductSealingEvent>().ReverseMap();
            //CreateMap<ProductSealingEventGetRequestByIdDTO, ProductSealingEvent>().ReverseMap();
            //CreateMap<ProductSealingEventGetRequestByGuidDTO, ProductSealingEvent>().ReverseMap();
            //CreateMap<ProductSealingEventCreateRequestDTO, ProductSealingEvent>().ReverseMap();
            CreateMap<ProductSealingEventUpdateRequestDTO, ProductSealingEvent>().ReverseMap();
            //CreateMap<ProductSealingEventDeleteRequestDTO, ProductSealingEvent>().ReverseMap();
        
            // ProductShippingEvent Mappings 
            //CreateMap<ProductShippingEventGetRequestDTO, ProductShippingEvent>().ReverseMap();
            //CreateMap<ProductShippingEventGetRequestByIdDTO, ProductShippingEvent>().ReverseMap();
            //CreateMap<ProductShippingEventGetRequestByGuidDTO, ProductShippingEvent>().ReverseMap();
            //CreateMap<ProductShippingEventCreateRequestDTO, ProductShippingEvent>().ReverseMap();
            CreateMap<ProductShippingEventUpdateRequestDTO, ProductShippingEvent>().ReverseMap();
            //CreateMap<ProductShippingEventDeleteRequestDTO, ProductShippingEvent>().ReverseMap();
        
            // ProductStage Mappings 
            //CreateMap<ProductStageGetRequestDTO, ProductStage>().ReverseMap();
            //CreateMap<ProductStageGetRequestByIdDTO, ProductStage>().ReverseMap();
            //CreateMap<ProductStageGetRequestByGuidDTO, ProductStage>().ReverseMap();
            //CreateMap<ProductStageCreateRequestDTO, ProductStage>().ReverseMap();
            CreateMap<ProductStageUpdateRequestDTO, ProductStage>().ReverseMap();
            //CreateMap<ProductStageDeleteRequestDTO, ProductStage>().ReverseMap();
        
            // ProductSurfacePreparationEvent Mappings 
            //CreateMap<ProductSurfacePreparationEventGetRequestDTO, ProductSurfacePreparationEvent>().ReverseMap();
            //CreateMap<ProductSurfacePreparationEventGetRequestByIdDTO, ProductSurfacePreparationEvent>().ReverseMap();
            //CreateMap<ProductSurfacePreparationEventGetRequestByGuidDTO, ProductSurfacePreparationEvent>().ReverseMap();
            //CreateMap<ProductSurfacePreparationEventCreateRequestDTO, ProductSurfacePreparationEvent>().ReverseMap();
            CreateMap<ProductSurfacePreparationEventUpdateRequestDTO, ProductSurfacePreparationEvent>().ReverseMap();
            //CreateMap<ProductSurfacePreparationEventDeleteRequestDTO, ProductSurfacePreparationEvent>().ReverseMap();
        
            // ProductVersionChangedEvent Mappings 
            //CreateMap<ProductVersionChangedEventGetRequestDTO, ProductVersionChangedEvent>().ReverseMap();
            //CreateMap<ProductVersionChangedEventGetRequestByIdDTO, ProductVersionChangedEvent>().ReverseMap();
            //CreateMap<ProductVersionChangedEventGetRequestByGuidDTO, ProductVersionChangedEvent>().ReverseMap();
            //CreateMap<ProductVersionChangedEventCreateRequestDTO, ProductVersionChangedEvent>().ReverseMap();
            CreateMap<ProductVersionChangedEventUpdateRequestDTO, ProductVersionChangedEvent>().ReverseMap();
            //CreateMap<ProductVersionChangedEventDeleteRequestDTO, ProductVersionChangedEvent>().ReverseMap();
        
            // ProductWiringEvent Mappings 
            //CreateMap<ProductWiringEventGetRequestDTO, ProductWiringEvent>().ReverseMap();
            //CreateMap<ProductWiringEventGetRequestByIdDTO, ProductWiringEvent>().ReverseMap();
            //CreateMap<ProductWiringEventGetRequestByGuidDTO, ProductWiringEvent>().ReverseMap();
            //CreateMap<ProductWiringEventCreateRequestDTO, ProductWiringEvent>().ReverseMap();
            CreateMap<ProductWiringEventUpdateRequestDTO, ProductWiringEvent>().ReverseMap();
            //CreateMap<ProductWiringEventDeleteRequestDTO, ProductWiringEvent>().ReverseMap();
        
            // ReferenceCellCalibration Mappings 
            //CreateMap<ReferenceCellCalibrationGetRequestDTO, ReferenceCellCalibration>().ReverseMap();
            //CreateMap<ReferenceCellCalibrationGetRequestByIdDTO, ReferenceCellCalibration>().ReverseMap();
            //CreateMap<ReferenceCellCalibrationGetRequestByGuidDTO, ReferenceCellCalibration>().ReverseMap();
            //CreateMap<ReferenceCellCalibrationCreateRequestDTO, ReferenceCellCalibration>().ReverseMap();
            CreateMap<ReferenceCellCalibrationUpdateRequestDTO, ReferenceCellCalibration>().ReverseMap();
            //CreateMap<ReferenceCellCalibrationDeleteRequestDTO, ReferenceCellCalibration>().ReverseMap();
        
            // ReferenceStandard Mappings 
            //CreateMap<ReferenceStandardGetRequestDTO, ReferenceStandard>().ReverseMap();
            //CreateMap<ReferenceStandardGetRequestByIdDTO, ReferenceStandard>().ReverseMap();
            //CreateMap<ReferenceStandardGetRequestByGuidDTO, ReferenceStandard>().ReverseMap();
            //CreateMap<ReferenceStandardCreateRequestDTO, ReferenceStandard>().ReverseMap();
            CreateMap<ReferenceStandardUpdateRequestDTO, ReferenceStandard>().ReverseMap();
            //CreateMap<ReferenceStandardDeleteRequestDTO, ReferenceStandard>().ReverseMap();
        
            // ShuntResistor Mappings 
            //CreateMap<ShuntResistorGetRequestDTO, ShuntResistor>().ReverseMap();
            //CreateMap<ShuntResistorGetRequestByIdDTO, ShuntResistor>().ReverseMap();
            //CreateMap<ShuntResistorGetRequestByGuidDTO, ShuntResistor>().ReverseMap();
            //CreateMap<ShuntResistorCreateRequestDTO, ShuntResistor>().ReverseMap();
            CreateMap<ShuntResistorUpdateRequestDTO, ShuntResistor>().ReverseMap();
            //CreateMap<ShuntResistorDeleteRequestDTO, ShuntResistor>().ReverseMap();
        
            // Test Mappings 
            //CreateMap<TestGetRequestDTO, Test>().ReverseMap();
            //CreateMap<TestGetRequestByIdDTO, Test>().ReverseMap();
            //CreateMap<TestGetRequestByGuidDTO, Test>().ReverseMap();
            //CreateMap<TestCreateRequestDTO, Test>().ReverseMap();
            CreateMap<TestUpdateRequestDTO, Test>().ReverseMap();
            //CreateMap<TestDeleteRequestDTO, Test>().ReverseMap();
        
            // Tester Mappings 
            //CreateMap<TesterGetRequestDTO, Tester>().ReverseMap();
            //CreateMap<TesterGetRequestByIdDTO, Tester>().ReverseMap();
            //CreateMap<TesterGetRequestByGuidDTO, Tester>().ReverseMap();
            //CreateMap<TesterCreateRequestDTO, Tester>().ReverseMap();
            CreateMap<TesterUpdateRequestDTO, Tester>().ReverseMap();
            //CreateMap<TesterDeleteRequestDTO, Tester>().ReverseMap();
        
            // TrimmingResistor Mappings 
            //CreateMap<TrimmingResistorGetRequestDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorGetRequestByIdDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorGetRequestByGuidDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorCreateRequestDTO, TrimmingResistor>().ReverseMap();
            CreateMap<TrimmingResistorUpdateRequestDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorDeleteRequestDTO, TrimmingResistor>().ReverseMap();
        
            // TrimmingResistor Mappings 
            //CreateMap<TrimmingResistorGetRequestDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorGetRequestByIdDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorGetRequestByGuidDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorCreateRequestDTO, TrimmingResistor>().ReverseMap();
            CreateMap<TrimmingResistorUpdateRequestDTO, TrimmingResistor>().ReverseMap();
            //CreateMap<TrimmingResistorDeleteRequestDTO, TrimmingResistor>().ReverseMap();
        
        }
        }
}