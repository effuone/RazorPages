using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages
{
    public class CurrencyModel : PageModel
    {
        public string Message { get; set; }
        private readonly decimal currentRate = 430m;
        public void OnGet()
        {
            Message = "Введите сумму";
        }
        public void OnPost(int? sum)
        {
            if (sum == null || sum < 1000)
            {
                Message = "Передана некорректная сумма. Повторите ввод";
            }
            else
            {
                decimal result = sum.Value / currentRate;
                Message = $"При обмене {sum} тенге вы получите {result.ToString("F2")}$.";
            }
        }
    }
}
