using LanguageExt;
using ProductionManager.Domain.Errors;
using ProductionManager.Domain.Interfaces;

namespace ProductionManager.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ProductionManagerContext _ctx;
        public UnitOfWork(ProductionManagerContext ctx) { _ctx = ctx;  }

        public async Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken)=>throw new NotImplementedException("Its not been used to commit for now individual repo implemented savechanges"); 
        public void Dispose(){_ctx?.Dispose();  GC.SuppressFinalize(this); }

        public MassfussionFunctionRepository _massfussionFunctionRepository ;
        public IMassfussionFunctionRepository MassfussionFunctionRepository => _massfussionFunctionRepository  ??= new MassfussionFunctionRepository(_ctx);

        public MassLoadApplicationRepository _massLoadApplicationRepository ;
        public IMassLoadApplicationRepository MassLoadApplicationRepository => _massLoadApplicationRepository  ??= new MassLoadApplicationRepository(_ctx);

        public RefreshTokenRepository _refreshTokenRepository ;
        public IRefreshTokenRepository RefreshTokenRepository => _refreshTokenRepository  ??= new RefreshTokenRepository(_ctx);

        public UsersGroupRepository _usersGroupRepository ;
        public IUsersGroupRepository UsersGroupRepository => _usersGroupRepository  ??= new UsersGroupRepository(_ctx);

        public AmplifierBoardRepository _amplifierBoardRepository ;
        public IAmplifierBoardRepository AmplifierBoardRepository => _amplifierBoardRepository  ??= new AmplifierBoardRepository(_ctx);

        public DefectTypeRepository _defectTypeRepository ;
        public IDefectTypeRepository DefectTypeRepository => _defectTypeRepository  ??= new DefectTypeRepository(_ctx);

        public DefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public IDefectTypeSolutionRepository DefectTypeSolutionRepository => _defectTypeSolutionRepository  ??= new DefectTypeSolutionRepository(_ctx);

        public LogDetailRepository _logDetailRepository ;
        public ILogDetailRepository LogDetailRepository => _logDetailRepository  ??= new LogDetailRepository(_ctx);

        public LogSummaryRepository _logSummaryRepository ;
        public ILogSummaryRepository LogSummaryRepository => _logSummaryRepository  ??= new LogSummaryRepository(_ctx);

        public ModelVersionRepository _modelVersionRepository ;
        public IModelVersionRepository ModelVersionRepository => _modelVersionRepository  ??= new ModelVersionRepository(_ctx);

        public NonConformanceLogRepository _nonConformanceLogRepository ;
        public INonConformanceLogRepository NonConformanceLogRepository => _nonConformanceLogRepository  ??= new NonConformanceLogRepository(_ctx);

        public ProductRepository _productRepository ;
        public IProductRepository ProductRepository => _productRepository  ??= new ProductRepository(_ctx);

        public ProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        public IProductAdditionalInfoRepository ProductAdditionalInfoRepository => _productAdditionalInfoRepository  ??= new ProductAdditionalInfoRepository(_ctx);

        public ProductCablingEventRepository _productCablingEventRepository ;
        public IProductCablingEventRepository ProductCablingEventRepository => _productCablingEventRepository  ??= new ProductCablingEventRepository(_ctx);

        public ProductCertificateRepository _productCertificateRepository ;
        public IProductCertificateRepository ProductCertificateRepository => _productCertificateRepository  ??= new ProductCertificateRepository(_ctx);

        public ProductCertificateTypeRepository _productCertificateTypeRepository ;
        public IProductCertificateTypeRepository ProductCertificateTypeRepository => _productCertificateTypeRepository  ??= new ProductCertificateTypeRepository(_ctx);

        public ProductFinalUnitRepository _productFinalUnitRepository ;
        public IProductFinalUnitRepository ProductFinalUnitRepository => _productFinalUnitRepository  ??= new ProductFinalUnitRepository(_ctx);

        public ProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        public IProductFinalVerifiationEventRepository ProductFinalVerifiationEventRepository => _productFinalVerifiationEventRepository  ??= new ProductFinalVerifiationEventRepository(_ctx);

        public ProductFinishedEventRepository _productFinishedEventRepository ;
        public IProductFinishedEventRepository ProductFinishedEventRepository => _productFinishedEventRepository  ??= new ProductFinishedEventRepository(_ctx);

        public ProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public IProductGaugeInspectionEventRepository ProductGaugeInspectionEventRepository => _productGaugeInspectionEventRepository  ??= new ProductGaugeInspectionEventRepository(_ctx);

        public ProductGaugeEventRepository _productGaugeEventRepository ;
        public IProductGaugeEventRepository ProductGaugeEventRepository => _productGaugeEventRepository  ??= new ProductGaugeEventRepository(_ctx);

        public ProductInitialUnitRepository _productInitialUnitRepository ;
        public IProductInitialUnitRepository ProductInitialUnitRepository => _productInitialUnitRepository  ??= new ProductInitialUnitRepository(_ctx);

        public ProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        public IProductInitialVerificationEventRepository ProductInitialVerificationEventRepository => _productInitialVerificationEventRepository  ??= new ProductInitialVerificationEventRepository(_ctx);

        public ProductInventoryEventRepository _productInventoryEventRepository ;
        public IProductInventoryEventRepository ProductInventoryEventRepository => _productInventoryEventRepository  ??= new ProductInventoryEventRepository(_ctx);

        public ProductLabellingEventRepository _productLabellingEventRepository ;
        public IProductLabellingEventRepository ProductLabellingEventRepository => _productLabellingEventRepository  ??= new ProductLabellingEventRepository(_ctx);

        public ProductMovingEventRepository _productMovingEventRepository ;
        public IProductMovingEventRepository ProductMovingEventRepository => _productMovingEventRepository  ??= new ProductMovingEventRepository(_ctx);

        public ProductPictureRepository _productPictureRepository ;
        public IProductPictureRepository ProductPictureRepository => _productPictureRepository  ??= new ProductPictureRepository(_ctx);

        public ProductReceptionEventRepository _productReceptionEventRepository ;
        public IProductReceptionEventRepository ProductReceptionEventRepository => _productReceptionEventRepository  ??= new ProductReceptionEventRepository(_ctx);

        public ProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        public IProductResistorInstallationEventRepository ProductResistorInstallationEventRepository => _productResistorInstallationEventRepository  ??= new ProductResistorInstallationEventRepository(_ctx);

        public ProductSealingEventRepository _productSealingEventRepository ;
        public IProductSealingEventRepository ProductSealingEventRepository => _productSealingEventRepository  ??= new ProductSealingEventRepository(_ctx);

        public ProductShippingEventRepository _productShippingEventRepository ;
        public IProductShippingEventRepository ProductShippingEventRepository => _productShippingEventRepository  ??= new ProductShippingEventRepository(_ctx);

        public ProductStageRepository _productStageRepository ;
        public IProductStageRepository ProductStageRepository => _productStageRepository  ??= new ProductStageRepository(_ctx);

        public ProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        public IProductSurfacePreparationEventRepository ProductSurfacePreparationEventRepository => _productSurfacePreparationEventRepository  ??= new ProductSurfacePreparationEventRepository(_ctx);

        public ProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public IProductVersionChangedEventRepository ProductVersionChangedEventRepository => _productVersionChangedEventRepository  ??= new ProductVersionChangedEventRepository(_ctx);

        public ProductWiringEventRepository _productWiringEventRepository ;
        public IProductWiringEventRepository ProductWiringEventRepository => _productWiringEventRepository  ??= new ProductWiringEventRepository(_ctx);

        public ReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        public IReferenceCellCalibrationRepository ReferenceCellCalibrationRepository => _referenceCellCalibrationRepository  ??= new ReferenceCellCalibrationRepository(_ctx);

        public ReferenceStandardRepository _referenceStandardRepository ;
        public IReferenceStandardRepository ReferenceStandardRepository => _referenceStandardRepository  ??= new ReferenceStandardRepository(_ctx);

        public ShuntResistorRepository _shuntResistorRepository ;
        public IShuntResistorRepository ShuntResistorRepository => _shuntResistorRepository  ??= new ShuntResistorRepository(_ctx);

        public TestRepository _testRepository ;
        public ITestRepository TestRepository => _testRepository  ??= new TestRepository(_ctx);

        public TesterRepository _testerRepository ;
        public ITesterRepository TesterRepository => _testerRepository  ??= new TesterRepository(_ctx);

        public TrimmingResistorRepository _trimmingResistorRepository ;
        public ITrimmingResistorRepository TrimmingResistorRepository => _trimmingResistorRepository  ??= new TrimmingResistorRepository(_ctx);
    }
}