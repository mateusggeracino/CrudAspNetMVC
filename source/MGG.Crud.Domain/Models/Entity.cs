using System;
using System.CodeDom;
using FluentValidation;
using FluentValidation.Results;

namespace MGG.Crud.Domain.Models
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }

        public abstract bool IsValid();
    }
}