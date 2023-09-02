using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Inacio Henrique Saraiva", "144.734.154-47", "ina199@hotmail.com", "Charlie");
        Cliente cliente2 = new Cliente(02, "Renato Alcantara da Silveira", "966.249.577-93", "Rena348@gmail.com", "Madame");
        Cliente cliente3 = new Cliente(03, "Arthur José de Barros", "997.403.435-66", "ArtZe35@outlook.com", "Duque");
        Cliente cliente4 = new Cliente(04, "Pandora Pitaia dos Santos", "238.919.562-69", "PanTaia@gmail.com", "Hades");
        Cliente cliente5 = new Cliente(05, "Persefone de oliveira", "199.001.724-74", "Perfone00@gmail.com", "Cenoura");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02,"ctrl alt dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "40.810.224/0001-34", "boots.pet@cachorromania.us");
        Fornecedor fornecedor4 = new Fornecedor(04,"Tik Tok Cats", "693.163.992/0001-12", "DanceCats@tiktokcats.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Costelinha Forever", "000.124.876/0001-04", "costelinha@steak.nk");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); 
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
