using Agenda.Database;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Controllers;

public class ContatosController : Controller
{
    private readonly ApplicationDbContext _applicationDbContext;
    
    public ContatosController(ApplicationDbContext applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
    }

    public IActionResult Criar()
    {
        return View("CriarContato");
    }

    public IActionResult Salvar(Contato contato)
    {
        if (contato.Id == 0)
        {
         _applicationDbContext.Contatos.Add(contato);
        }
        else
        {
            Contato contatoReturned = _applicationDbContext.Contatos.Find(contato.Id);
            contatoReturned.Nome = contato.Nome ;
            contatoReturned.Telefone = contato.Telefone;
            contatoReturned.Ativo =  contato.Ativo;
            _applicationDbContext.Update(contatoReturned);
        }
        _applicationDbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Index()
    {
        var lista = _applicationDbContext.Contatos.ToList();
        return View(lista);
    }

    public IActionResult Editar(int id)
    {
        Contato contatoReturned = _applicationDbContext.Contatos.Find(id);
        return View("CriarContato",contatoReturned);
    }

    public IActionResult Excluir(int id)
    {
        Contato contatoReturned = _applicationDbContext.Contatos.Find(id);
        _applicationDbContext.Remove(contatoReturned);
        _applicationDbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    
}