// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.store_type_selector_view")]
    [ExplicitColumns]
    public sealed class StoreTypeSelectorView : PetaPocoDB.Record<StoreTypeSelectorView>, IPoco
    {
        [Column("store_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreTypeId { get; set; }

        [Column("store_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string StoreTypeCode { get; set; }

        [Column("store_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string StoreTypeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}