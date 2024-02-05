using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ApiCliente.Services.Configurations
{
    public class SwaggerConfiguration
    {
        public static void AddSwagger(WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options=>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Api de Controle de clientes",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Coti Teste",
                        Email = "Cotato@Contao.com",
                        Url = new Uri("http://www.teste.com"),
                    }
                });


                //Gera um arquivo dentro da pasta de compilação do projeto 
                //contendo os comentários XML feitos no código fonte
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath=Path.Combine(AppContext.BaseDirectory, xmlFile);

                //configurando o swagger para incluir os comentários XML do código
                //necessita de alteração no arquivo do projeto, deixar assim como está abaixo.
                //< PropertyGroup >
                //   TargetFramework > net7.0 </ TargetFramework 
                //   Nullable > enable </ Nullable 
                //   ImplicitUsings > enable </ ImplicitUsings 
                //   GenerateDocumentationFile > true </ GenerateDocumentatioFile 
                //   NoWarn >$(NoWarn); 1591 </ NoWarn 
                //</ PropertyGroup >
                options.IncludeXmlComments(xmlPath);



            });
        }
    }
}
