using MGG.Crud.Application.Interfaces;
using MGG.Crud.Application.ViewModels;
using PagedList;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MGG.Crud.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: Product
        public ActionResult Index(int pagina = 1)
        {
            var products = _productAppService.GetAll();

            return View(products.ToPagedList(pagina, 5));
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel product)
        {
            var productUp = _productAppService.Create(product);

            if (productUp.ValidationResult.Errors.Any())
            {
                Alert("Erro", "Erro ao cadastrar produto", "error");
                return View();
            }
            
            Alert("Cadastrado", "Produto cadastrado com sucesso.", "success");
            var products = _productAppService.GetAll();
            return View("Index", products.ToPagedList(1,5));
        }

        [Authorize]
        public ActionResult Edit(Guid id)
        {
            var product = _productAppService.Read(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel product)
        {
            var productUp = _productAppService.Update(product);

            return View(productUp);
        }

        public ActionResult Details(Guid id)
        {
            var product = _productAppService.Read(id);

            return View(product);
        }

        [Authorize]
        public ActionResult Delete(Guid id)
        {
            var product = _productAppService.Read(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}