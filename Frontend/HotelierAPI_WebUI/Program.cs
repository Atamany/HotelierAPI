using FluentValidation;
using FluentValidation.AspNetCore;
using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_BusinessLayer.Concrete;
using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Concrete;
using HotelierAPI_DataAccessLayer.EntityFramework;
using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_WebUI.DTOs.GuestDTO;
using HotelierAPI_WebUI.ValidationRules.GuestValidationRules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IValidator<CreateGuestDTO>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDTO>, UpdateGuestValidator>();
builder.Services.AddControllersWithViews();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
