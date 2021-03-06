﻿
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[SCMTypes]")]
    [DisplayName("SCM Types"), InstanceName("SCM Types")]

    // xác định quyền tương ứng cho bảng SCMTypes
    [ReadPermission(PermissionKeys.SCMType.View)]
    [ModifyPermission(PermissionKeys.SCMType.Modify)]
    [DeletePermission(PermissionKeys.SCMType.Delete)]

    public sealed class SCMTypesRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), PrimaryKey, AlignCenter]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(50), QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SCMTypesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
        }
    }
}
