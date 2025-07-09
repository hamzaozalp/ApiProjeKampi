using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(X => X.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(X => X.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın!");
            RuleFor(X => X.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın!");

            RuleFor(X => X.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").LessThan(0).WithMessage("Ürün fiyatı negatif olamaz").GreaterThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz,girdiğiniz değeri kontrol edin!");

            RuleFor(X => X.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
        }
    }
}
