namespace Scolus.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDatabaseSetUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        StreetNumber = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        StreetAddress2 = c.String(),
                        City = c.String(nullable: false),
                        PostalCode = c.String(),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PhoneId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FacultyId)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: false)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: false)
                .Index(t => t.SchoolId)
                .Index(t => t.PositionId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.FacultyCustomFieldValues",
                c => new
                    {
                        FacultyCustomFieldValueId = c.Int(nullable: false, identity: true),
                        FacultyCustomFieldSetUpId = c.Int(nullable: false),
                        FacultyID = c.Int(nullable: false),
                        Value = c.String(),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FacultyCustomFieldValueId)
                .ForeignKey("dbo.Faculties", t => t.FacultyID, cascadeDelete: true)
                .ForeignKey("dbo.FacultyCustomFieldSetUps", t => t.FacultyCustomFieldSetUpId, cascadeDelete: true)
                .Index(t => t.FacultyCustomFieldSetUpId)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.FacultyCustomFieldSetUps",
                c => new
                    {
                        FacultyCustomFieldSetUpId = c.Int(nullable: false, identity: true),
                        CustomFieldId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        Required = c.Boolean(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FacultyCustomFieldSetUpId)
                .ForeignKey("dbo.CustomFields", t => t.CustomFieldId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.CustomFieldId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.CustomFields",
                c => new
                    {
                        CustomFieldId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomFieldId);
            
            CreateTable(
                "dbo.CustomFieldOptions",
                c => new
                    {
                        CustomFieldOptionId = c.Int(nullable: false, identity: true),
                        CustomFieldId = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomFieldOptionId)
                .ForeignKey("dbo.CustomFields", t => t.CustomFieldId, cascadeDelete: true)
                .Index(t => t.CustomFieldId);
            
            CreateTable(
                "dbo.SchoolCustomFieldSetUps",
                c => new
                    {
                        SchoolCustomFieldSetUpId = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        CustomFieldId = c.Int(nullable: false),
                        Required = c.Boolean(nullable: false),
                        Value = c.String(),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolCustomFieldSetUpId)
                .ForeignKey("dbo.CustomFields", t => t.CustomFieldId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId)
                .Index(t => t.CustomFieldId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        Type = c.Int(nullable: false),
                        ReferenceId = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PositionId)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.StudentCustomFieldSetUps",
                c => new
                    {
                        StudentCustomFieldSetUpId = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        CustomFieldId = c.Int(nullable: false),
                        Required = c.Boolean(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentCustomFieldSetUpId)
                .ForeignKey("dbo.CustomFields", t => t.CustomFieldId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId)
                .Index(t => t.CustomFieldId);
            
            CreateTable(
                "dbo.StudentCustomFieldValues",
                c => new
                    {
                        StudentCustomFieldValueId = c.Int(nullable: false, identity: true),
                        StudentCustomFieldSetUpId = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Value = c.String(),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentCustomFieldValueId)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.StudentCustomFieldSetUps", t => t.StudentCustomFieldSetUpId, cascadeDelete: true)
                .Index(t => t.StudentCustomFieldSetUpId)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        StudentType = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PhoneId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Phones", t => t.PhoneId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: false)
                .Index(t => t.SchoolId)
                .Index(t => t.AddressId)
                .Index(t => t.PhoneId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 11),
                        Extension = c.String(),
                        Type = c.Int(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneId);
            
            CreateTable(
                "dbo.EntityLookUps",
                c => new
                    {
                        EntityLookUpId = c.Int(nullable: false, identity: true),
                        EntityCode = c.String(nullable: false),
                        Value = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntityLookUpId);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Salt = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Faculties", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.FacultyCustomFieldValues", "FacultyCustomFieldSetUpId", "dbo.FacultyCustomFieldSetUps");
            DropForeignKey("dbo.FacultyCustomFieldSetUps", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.FacultyCustomFieldSetUps", "CustomFieldId", "dbo.CustomFields");
            DropForeignKey("dbo.SchoolCustomFieldSetUps", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.StudentCustomFieldValues", "StudentCustomFieldSetUpId", "dbo.StudentCustomFieldSetUps");
            DropForeignKey("dbo.StudentCustomFieldValues", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Students", "PhoneId", "dbo.Phones");
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.StudentCustomFieldSetUps", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.StudentCustomFieldSetUps", "CustomFieldId", "dbo.CustomFields");
            DropForeignKey("dbo.Positions", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.SchoolCustomFieldSetUps", "CustomFieldId", "dbo.CustomFields");
            DropForeignKey("dbo.CustomFieldOptions", "CustomFieldId", "dbo.CustomFields");
            DropForeignKey("dbo.FacultyCustomFieldValues", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.Faculties", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "PhoneId" });
            DropIndex("dbo.Students", new[] { "AddressId" });
            DropIndex("dbo.Students", new[] { "SchoolId" });
            DropIndex("dbo.StudentCustomFieldValues", new[] { "StudentID" });
            DropIndex("dbo.StudentCustomFieldValues", new[] { "StudentCustomFieldSetUpId" });
            DropIndex("dbo.StudentCustomFieldSetUps", new[] { "CustomFieldId" });
            DropIndex("dbo.StudentCustomFieldSetUps", new[] { "SchoolId" });
            DropIndex("dbo.Positions", new[] { "SchoolId" });
            DropIndex("dbo.SchoolCustomFieldSetUps", new[] { "CustomFieldId" });
            DropIndex("dbo.SchoolCustomFieldSetUps", new[] { "SchoolId" });
            DropIndex("dbo.CustomFieldOptions", new[] { "CustomFieldId" });
            DropIndex("dbo.FacultyCustomFieldSetUps", new[] { "SchoolId" });
            DropIndex("dbo.FacultyCustomFieldSetUps", new[] { "CustomFieldId" });
            DropIndex("dbo.FacultyCustomFieldValues", new[] { "FacultyID" });
            DropIndex("dbo.FacultyCustomFieldValues", new[] { "FacultyCustomFieldSetUpId" });
            DropIndex("dbo.Faculties", new[] { "AddressId" });
            DropIndex("dbo.Faculties", new[] { "PositionId" });
            DropIndex("dbo.Faculties", new[] { "SchoolId" });
            DropTable("dbo.UserAccounts");
            DropTable("dbo.EntityLookUps");
            DropTable("dbo.Phones");
            DropTable("dbo.Students");
            DropTable("dbo.StudentCustomFieldValues");
            DropTable("dbo.StudentCustomFieldSetUps");
            DropTable("dbo.Positions");
            DropTable("dbo.Schools");
            DropTable("dbo.SchoolCustomFieldSetUps");
            DropTable("dbo.CustomFieldOptions");
            DropTable("dbo.CustomFields");
            DropTable("dbo.FacultyCustomFieldSetUps");
            DropTable("dbo.FacultyCustomFieldValues");
            DropTable("dbo.Faculties");
            DropTable("dbo.Addresses");
        }
    }
}
