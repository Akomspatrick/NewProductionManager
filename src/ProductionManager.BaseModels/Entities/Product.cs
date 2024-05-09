
using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKey("ModelVersion", "Products")]
    public class Product : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public required int ProductId { get; init; } // SerialNo
        [BaseModelBasicAttribute(false, true)]
        public int ModelVersionId { get; init; }
        [BaseModelBasicAttribute(32, 0, false, true)]
        public required string ModelName { get; init; } = string.Empty;

        public required int Capacity { get; init; }
        public required DateTime Timestamp { get; init; }


        public required string Stage { get; init; } = string.Empty;

        public string SubStage { get; init; } = string.Empty;

        public string InvoiceId { get; init; } = string.Empty;
        public string SalesOrderId { get; init; } = string.Empty;

        public required int CableLength { get; init; } = 0;
        public required int InspectionResult { get; init; } = 0;
        public string DefaultTestingMode { get; init; } = string.Empty; // Manual, Automatic from the Model Type
        public string ModelTypeGroupName { get; init; } = string.Empty;// DefaultTestingMode and ModelTypeGroupName should be taken from the ModelTypeGroup via ModelType
        public string UsedTestingMode { get; init; } = string.Empty; // default to aboveManual, Automatic from the Model Type
        public string ThermexPurcharseOrderNo { get; init; } = string.Empty;//stage
        public string MachiningPurcharseOrderNo { get; init; } = string.Empty;//stage
        public string SteelPurcharseOrderNo { get; init; } = string.Empty;
        public int BatcNo { get; init; } //stage
        public string LoadDirection { get; init; } = string.Empty;// This will be a frontend dropdown list with values: "Compression", "Testing", "Both"
        public ICollection<Test> Tests { get; init; }
        public ICollection<ProductInitialUnit> ProductInitialUnits { get; init; }
        public ICollection<ProductFinalUnit> ProductFinalUnits { get; init; }
        public ICollection<ProductCertificate> ProductCertificates { get; init; }
        public ICollection<NonConformanceLog> NonConformanceLogs { get; init; }

        // public ICollection<BaseEvent> BaseEvents { get; init; }
        // public modelcapacityspecification

        public ModelVersion? ModelVersion { get; init; }
        public ICollection<ProductPicture> ProductPictures { get; init; }


        //      PRIMARY KEY(`serial`),
        //INDEX `fk_products_modelCapacitySpecifications1` (`modelCapacitySpecifications_models_name` ASC, `modelCapacitySpecifications_capacity` ASC, `modelCapacitySpecifications_timestamp` ASC) VISIBLE,
        //CONSTRAINT `fk_products_modelCapacitySpecifications1`
        //  FOREIGN KEY(`modelCapacitySpecifications_models_name` , `modelCapacitySpecifications_capacity` , `modelCapacitySpecifications_timestamp`)
        //  REFERENCES `mydb_test`.`modelcapacityspecifications` (`models_name` , `capacity` , `timestamp`)

    }
}
