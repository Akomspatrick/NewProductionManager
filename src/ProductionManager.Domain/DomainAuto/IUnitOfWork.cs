using LanguageExt;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken);
        IAmplifierBoardRepository AmplifierBoardRepository { get; }
        IDefectTypeRepository DefectTypeRepository { get; }
        IDefectTypeSolutionRepository DefectTypeSolutionRepository { get; }
        ILogDetailRepository LogDetailRepository { get; }
        ILogSummaryRepository LogSummaryRepository { get; }
        IModelVersionRepository ModelVersionRepository { get; }
        INonConformanceLogRepository NonConformanceLogRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductAdditionalInfoRepository ProductAdditionalInfoRepository { get; }
        IProductCablingEventRepository ProductCablingEventRepository { get; }
        IProductCertificateRepository ProductCertificateRepository { get; }
        IProductCertificateTypeRepository ProductCertificateTypeRepository { get; }
        IProductFinalUnitRepository ProductFinalUnitRepository { get; }
        IProductFinalVerifiationEventRepository ProductFinalVerifiationEventRepository { get; }
        IProductFinishedEventRepository ProductFinishedEventRepository { get; }
        IProductGaugeInspectionEventRepository ProductGaugeInspectionEventRepository { get; }
        IProductGaugeEventRepository ProductGaugeEventRepository { get; }
        IProductInitialUnitRepository ProductInitialUnitRepository { get; }
        IProductInitialVerificationEventRepository ProductInitialVerificationEventRepository { get; }
        IProductInventoryEventRepository ProductInventoryEventRepository { get; }
        IProductLabellingEventRepository ProductLabellingEventRepository { get; }
        IProductMovingEventRepository ProductMovingEventRepository { get; }
        IProductPictureRepository ProductPictureRepository { get; }
        IProductReceptionEventRepository ProductReceptionEventRepository { get; }
        IProductResistorInstallationEventRepository ProductResistorInstallationEventRepository { get; }
        IProductSealingEventRepository ProductSealingEventRepository { get; }
        IProductShippingEventRepository ProductShippingEventRepository { get; }
        IProductStageRepository ProductStageRepository { get; }
        IProductSurfacePreparationEventRepository ProductSurfacePreparationEventRepository { get; }
        IProductVersionChangedEventRepository ProductVersionChangedEventRepository { get; }
        IProductWiringEventRepository ProductWiringEventRepository { get; }
        IReferenceCellCalibrationRepository ReferenceCellCalibrationRepository { get; }
        IReferenceStandardRepository ReferenceStandardRepository { get; }
        IShuntResistorRepository ShuntResistorRepository { get; }
        ITestRepository TestRepository { get; }
        ITesterRepository TesterRepository { get; }
        ITrimmingResistorRepository TrimmingResistorRepository { get; }
    }
}