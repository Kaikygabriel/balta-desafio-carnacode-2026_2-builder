 using System;
 using src.Builders;

 Console.WriteLine("=== Sistema de Relatórios ===");
 
 var report1 = BuilderSales.Configure()
     .WithTitle("Vendas Mensais")
     .WithFormat("PDF")
     .WithGroupBy("Categoria")
     .WithCompanyLogo("logo.png")
     .WithWaterMark("Confidencial")
     .WithSortBy("Valor")
     .WithEndDate(new DateTime(2024, 1, 31))
     .WithHeaderText("Relatório de Vendas")
     .WithPageSize("A4")
     .Build();
 
 report1.Generate();

 var report2 = BuilderSales.Configure()
     .WithTitle("Relatório Trimestral")
     .WithFormat("Excel")
     .WithGroupBy("Região")
     .WithCompanyLogo("logo.png")
     .WithWaterMark("Confidencial")
     .WithSortBy("Vendedor")
     .WithEndDate(new DateTime(2024, 3, 31))
     .WithCharts("Line")
     .WithPageSize("A4")
     .Build();
 
 report2.Generate();
 
 // Perguntas para reflexão:
 // - Como criar relatórios complexos sem construtores gigantes?
 // - Como garantir que configurações obrigatórias sejam definidas?
 // - Como reutilizar configurações comuns entre relatórios?
 // - Como tornar o processo de criação mais legível e fluente?