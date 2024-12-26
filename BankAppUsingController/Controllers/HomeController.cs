using BankAppUsingController.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankAppUsingController.Controllers
{
	public class HomeController : Controller
	{
		private static readonly bankDetails bankdetails = new bankDetails
		{
			AccountNumber = 101,
			AccountName = "Test",
			CurrentBalance = 5000
		};
		[Route("/")]
		public IActionResult Index()
		{
			return Content("Welcome to the best bank", "text/plain");
		}

		[Route("/account-details")]
		public IActionResult Account()
		{
			return Ok(bankdetails);
		}

		[Route("/account-statement")]
		public IActionResult ABC()
		{
			return File("~/dummy.pdf", "application/pdf");
		}

		[Route("/get-current-balance/{accountnumber:int}")]
		public IActionResult AccountBalance(int accountnumber)
		{
			if(accountnumber == bankdetails.AccountNumber)
			{
				return Ok(bankdetails.CurrentBalance);
			}
			return BadRequest("Account Number should be 1001");
		}

		[Route("/get-current-balance")]
		public IActionResult ProvideMore()
		{
			return NotFound("Account number should be supplied");
		}
	}
}
