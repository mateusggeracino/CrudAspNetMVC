using System;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace MGG.Crud.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Breve Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime RegisterDate { get; set; }

        public ValidationResult ValidationResult { get; set; }
    }
}