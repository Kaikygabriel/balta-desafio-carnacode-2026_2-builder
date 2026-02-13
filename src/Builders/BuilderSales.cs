using System;
using src.Builders.Interface;
using src.Entities;
using src.Entities.Interfaces;

namespace src.Builders;

public class BuilderSales : IBuilderSales,
    ICreateTitle,
    ICreateFormat,
    ICreateGroupBy,
    ICreateLogo,
    ICreateMark,
    ICreateSortBy
{
    private SalesReport _salesReport ;

    private BuilderSales()
    {
        _salesReport = new SalesReport();
    }

    public static ICreateTitle Configure()
        => new BuilderSales();

    public ICreateFormat WithTitle(string title)
    {
        _salesReport.Title = title;
        return this;
    }
    
    public ICreateGroupBy WithFormat(string format)
    {
        _salesReport.Format = format;
        return this;
    } 
    public BuilderSales WithEndDate(DateTime endDate)
    {
        _salesReport.EndDate = endDate;
        return this;
    } 

    public BuilderSales WithSortBy(string SortBy)
    {
        _salesReport.SortBy = SortBy;
        return this;
    } 

    public ICreateLogo WithGroupBy(string GroupBy)
    {
        _salesReport.GroupBy = GroupBy;
        return this;
    } 
    
    public ICreateMark WithCompanyLogo(string CompanyLogo)
    {
        _salesReport.CompanyLogo = CompanyLogo;
        return this;
    }
    
    public ICreateSortBy WithWaterMark(string WaterMark)
    {
        _salesReport.WaterMark = WaterMark;
        return this;
    }

    public BuilderSales WithHeaderText(string HeaderText)
    {
        _salesReport.HeaderText = HeaderText;
        _salesReport.IncludeHeader = true;
        return this;
    }
    
    public BuilderSales WithCharts(string Charts)
    {
        _salesReport.ChartType = Charts;
        _salesReport.IncludeCharts = true;
        return this;
    }
    public BuilderSales WithPageSize(string pageSize)
    {
        _salesReport.PageSize = pageSize;
        return this;
    }
    public SalesReport Build()
    {
        return _salesReport;
    }
}