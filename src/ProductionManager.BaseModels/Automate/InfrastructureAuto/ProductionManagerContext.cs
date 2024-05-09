using ProductionManager.Domain.Entities;
using ProductionManager.Domain.Utils;
using ProductionManager.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace ProductionManager.Infrastructure.Persistence
{
    public class ProductionManagerContext : DbContext
    {
        private readonly IConfiguration _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = GetConnectionstringName.GetConnectionStrName(Environment.MachineName);
            var conn = _configuration.GetConnectionString(constr);
            optionsBuilder.UseMySql(conn!, GeneralUtils.GetMySqlVersion());
        }
        public ProductionManagerContext(DbContextOptions<ProductionManagerContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductionManagerContext).Assembly);
        }
        
        public DbSet<MassfussionFunction> MassfussionFunctions { get; private set; }
        public DbSet<MassLoadApplication> MassLoadApplications { get; private set; }
        public DbSet<RefreshToken> RefreshTokens { get; private set; }
        public DbSet<UsersGroup> UsersGroups { get; private set; }
        public DbSet<AmplifierBoard> AmplifierBoards { get; private set; }
        public DbSet<DefectType> DefectTypes { get; private set; }
        public DbSet<DefectTypeSolution> DefectTypeSolutions { get; private set; }
        public DbSet<LogDetail> LogDetails { get; private set; }
        public DbSet<LogSummary> LogSummarys { get; private set; }
        public DbSet<ModelVersion> ModelVersions { get; private set; }
        public DbSet<NonConformanceLog> NonConformanceLogs { get; private set; }
        public DbSet<Product> Products { get; private set; }
        public DbSet<ProductAdditionalInfo> ProductAdditionalInfos { get; private set; }
        public DbSet<ProductCablingEvent> ProductCablingEvents { get; private set; }
        public DbSet<ProductCertificate> ProductCertificates { get; private set; }
        public DbSet<ProductCertificateType> ProductCertificateTypes { get; private set; }
        public DbSet<ProductFinalUnit> ProductFinalUnits { get; private set; }
        public DbSet<ProductFinalVerifiationEvent> ProductFinalVerifiationEvents { get; private set; }
        public DbSet<ProductFinishedEvent> ProductFinishedEvents { get; private set; }
        public DbSet<ProductGaugeInspectionEvent> ProductGaugeInspectionEvents { get; private set; }
        public DbSet<ProductGaugeEvent> ProductGaugeEvents { get; private set; }
        public DbSet<ProductInitialUnit> ProductInitialUnits { get; private set; }
        public DbSet<ProductInitialVerificationEvent> ProductInitialVerificationEvents { get; private set; }
        public DbSet<ProductInventoryEvent> ProductInventoryEvents { get; private set; }
        public DbSet<ProductLabellingEvent> ProductLabellingEvents { get; private set; }
        public DbSet<ProductMovingEvent> ProductMovingEvents { get; private set; }
        public DbSet<ProductPicture> ProductPictures { get; private set; }
        public DbSet<ProductReceptionEvent> ProductReceptionEvents { get; private set; }
        public DbSet<ProductResistorInstallationEvent> ProductResistorInstallationEvents { get; private set; }
        public DbSet<ProductSealingEvent> ProductSealingEvents { get; private set; }
        public DbSet<ProductShippingEvent> ProductShippingEvents { get; private set; }
        public DbSet<ProductStage> ProductStages { get; private set; }
        public DbSet<ProductSurfacePreparationEvent> ProductSurfacePreparationEvents { get; private set; }
        public DbSet<ProductVersionChangedEvent> ProductVersionChangedEvents { get; private set; }
        public DbSet<ProductWiringEvent> ProductWiringEvents { get; private set; }
        public DbSet<ReferenceCellCalibration> ReferenceCellCalibrations { get; private set; }
        public DbSet<ReferenceStandard> ReferenceStandards { get; private set; }
        public DbSet<ShuntResistor> ShuntResistors { get; private set; }
        public DbSet<Test> Tests { get; private set; }
        public DbSet<Tester> Testers { get; private set; }
        public DbSet<TrimmingResistor> TrimmingResistors { get; private set; }
    }
}