namespace ProjectOrganization;

public class TableDataViewManagerFactory
{
    private readonly Dictionary<string, ITableDataViewManager> managers = new()
    {
        {"attribute_data", new TableDataManager<AttributeData>()},
        {"customer_data", new TableDataManager<CustomerData>()},
        {"employee_data", new TableDataManager<EmployeeData>()},
        {"deal_data", new TableDataManager<DealData>()},
        {"department_data", new TableDataManager<DepartmentData>()},
        {"equipment_data", new TableDataManager<EquipmentData>()},
        {"project_data", new TableDataManager<ProjectData>()},
        {"title_data", new TableDataManager<TitleData>()},
        {"suborganization_data", new TableDataManager<SuborganizationData>()},
        {"deal_project_link", new TableDataManager<DealProjectLink>()},
        {"employee_attribute_link", new TableDataManager<EmployeeAttributeLink>()},
        {"employee_deal_link", new TableDataManager<EmployeeDealLink>()},
        {"employee_department_link", new TableDataManager<EmployeeDepartmentLink>()},
        {"employee_project_link", new TableDataManager<EmployeeProjectLink>()},
        {"equipment_department_link", new TableDataManager<EquipmentDepartmentLink>()},
        {"equipment_project_link", new TableDataManager<EquipmentProjectLink>()},
        {"suborganization_project_link", new TableDataManager<SuborganizationProjectLink>()},
        {"title_attribute_link", new TableDataManager<TitleAttributeLink>()}
    };

    public ITableDataViewManager GetManagerForTable(string tableName)
    {
        return managers[tableName];
    }
}