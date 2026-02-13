using System;

namespace src.Builders.Interface;

public interface ICreateEndDate
{
    public BuilderSales WithEndDate(DateTime endDate);
}