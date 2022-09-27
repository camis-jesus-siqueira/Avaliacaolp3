
using Microsoft.AspNetCore.Mvc;
using Avaliacaolp3.ViewModels;
namespace Avaliacaolp3.Controllers;

public class LojaController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>();

    public IActionResult Index() => View(lojas);

    public IActionResult Admin() => View(lojas);

    public IActionResult Show(int id) => View(lojas[id-1]);

    public IActionResult Cadastrar() => View();

    public IActionResult CreateLoja(string? descricao, string? email, int id, string? nome, string? piso,  string? tipo)
    {
        if (lojas.Any(y => y.Nome == nome))
        {
            TempData["NameError"] = "Loja localizada com esse nome!";
            return RedirectToAction("Admin");
        } 
        else
        {
            id = lojas.Count + 1;

            lojas.Add(new LojaViewModel(descricao,email, id, nome, piso, tipo));

            return RedirectToAction("Admin");
        }
    }

    public IActionResult DeleteLoja(int id)
    {
        lojas.RemoveAll(x => x.Id == id);

        return RedirectToAction("Admin");
    }
}