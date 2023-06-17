using Microsoft.AspNetCore.Http;
using WebShop.Models;
using WebShop.ModelViews;

namespace WebShop.Models
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(MuaHangVM model, HttpContext context);
        MuaHangSuccessVM PaymentExecute(IQueryCollection collections);
    }
}