var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<MyDbContext>();

builder.Services.AddCors(options => options.AddPolicy(name: "fontendui",
			   policy =>
			   {
				   policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
			   }
			   ));

var app = builder.Build();
app.UseCors("fontendui");

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();



app.MapControllers();
app.Run();
