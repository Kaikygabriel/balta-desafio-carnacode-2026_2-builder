namespace src.Entities.Interfaces;

public interface ISalesReport
{
    string Title { get; set; }
    void Generate();
}