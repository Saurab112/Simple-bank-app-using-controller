using BankAppUsingController.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


//app.MapGet("/", () =>
//{
//	return Results.Ok("Welcome to the best bank");
//});
//var bankdetails = new bankDetails()
//{
//	AccountNumber = 101,
//	AccountName = "Test",
//	CurrentBalance = 5000
//};

//app.MapGet("/account-details", () =>
//{

//	return Results.Ok(bankdetails);
//});

//app.MapGet("/account-statement", () =>
//{

//	return Results.File("~/dummy.pdf", "application/pdf");
//});

//app.MapGet("/get-current-balance/{AccountNumber:int}", (int accountnumber) =>
//{
//	if(accountnumber == bankdetails.AccountNumber)
//	{
//		return Results.Ok(bankdetails.CurrentBalance);
//	}
//	else
//	{
//		return Results.NotFound("Account number should be valid");
//	}
//});

//app.MapGet("/get-current-balance", () =>
//{
//	return Results.NotFound("Account number should be supplied");
//});
app.Run();
