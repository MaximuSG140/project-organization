using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace ProjectOrganization
{
    [Table("employee_data")]
    internal class EmployeeData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("title_id")]
        public int TitleId { get; set; }
    }

    [Table("project_data")]
    internal class ProjectData
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]

        public string Name { get; set; }
        [Column("begin")]
        public DateTime Begin { get; set; }

        [Column("end")]
        public DateTime End { get; set; }

        [Column("cost")]
        public int Cost { get; set; }

        [Column("leader_id")]
        public int LeaderId { get; set; }
    }

    [Table("attribute_data")]
    internal class AttributeData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("deal_data")]
    internal class DealData
    {
        [Key]
        public int Id { get; set; }

        [Column("begin")]
        public DateTime Begin { get; set; }

        [Column("end")]
        public DateTime End { get; set; }

        [Column("leader_id")]
        public int LeaderId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }
    }

    [Table("title_data")]
    internal class TitleData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("customer_data")]
    internal class CustomerData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("equipment_data")]
    internal class EquipmentData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("department_data")]
    internal class DepartmentData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("leader_id")]
        public int LeaderId { get; set; }
    }

    [Table("suborganization_data")]
    internal class SuborganizationData
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("deal_project_link")]
    [PrimaryKey("DealId", "ProjectId")]
    internal class DealProjectLink
    {
        [Column("deal_id")]
        public int DealId { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }
    }

    [Table("employee_department_link")]
    [PrimaryKey("EmployeeId", "DepartmentId")]
    internal class EmployeeDepartmentLink
    {
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }
    }

    [Table("employee_attribute_link")]
    [PrimaryKey("EmployeeId", "AttributeId")]
    internal class EmployeeAttributeLink
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("attribute_id")]
        public int AttributeId { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }

    [Table("employee_deal_link")]
    [PrimaryKey("EmployeeId", "DealId")]
    internal class EmployeeDealLink
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("deal_id")]
        public int DealId { get; set; }
    }

    [Table("employee_project_link")]
    [PrimaryKey("EmployeeId", "ProjectId")]
    internal class EmployeeProjectLink
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }
    }

    [Table("equipment_department_link")]
    [PrimaryKey("EquipmentId", "DepartmentId")]
    internal class EquipmentDepartmentLink
    {
        [Column("equipment_id")]
        public int EquipmentId { get; set; }

        [Column("department_id")]
        public int DepartmentId { get; set; }
    }

    [Table("equipment_project_link")]
    [PrimaryKey("EquipmentId", "ProjectId")]
    internal class EquipmentProjectLink
    {
        [Column("equipment_id")] public int EquipmentId { get; set; }

        [Column("project_id")] public int ProjectId { get; set; }
    }

    [Table("suborganization_project_link")]
    [PrimaryKey("SuborganizationId", "ProjectId")]
    internal class SuborganizationProjectLink
    {
        [Column("suborganization_id")]
        public int SuborganizationId { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }
    }

    [Table("title_attribute_link")]
    [PrimaryKey("TitleId", "AttributeId")]
    internal class TitleAttributeLink
    {
        [Column("title_id")] 
        public int TitleId { get; set; }

        [Column("attribute_id")]
        public int AttributeId { get; set; }
    }

    internal interface IDatabaseConnection
    {
        Table<TData> Get<TData>() where TData : class;

        MySqlConnection? AsMySqlConnection();
        
        void Shutdown();
    }
}
