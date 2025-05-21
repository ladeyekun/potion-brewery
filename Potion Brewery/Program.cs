using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PotionBrewery.BLL;
using PotionBrewery.DAL;

namespace Potion_Brewery
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var services = new ServiceCollection();
            services.AddDbContext<PotionBreweryDbContext>(); // Registers DbContext with DI
            services.AddScoped<Form1>();
            services.AddScoped<IngredientForm>();
            services.AddScoped<IngredientEditorForm>();
            services.AddScoped<PotionRecipeForm>();
            services.AddScoped<PotionRecipeEditorForm>();

            services.AddScoped<IngredientRepository>();
            services.AddScoped<IngredientService>();
            services.AddScoped<BrewedPotionRepository>();
            services.AddScoped<BrewedPotionService>();
            services.AddScoped<PotionRecipeRepository>();
            services.AddScoped<PotionRecipeService>();
            services.AddScoped<RecipeIngredientRepository>();
            services.AddScoped<RecipeIngredientService>();

            ServiceProvider = services.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);

        }

    }
}