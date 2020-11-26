using Kentico.Kontent.Delivery.Abstractions;
using Kontent.Statiq;
using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;
using KenticoKontentModels;

public class ArticlesPipeline : Pipeline
{
    public ArticlesPipeline(IDeliveryClient client)
    {
        InputModules = new ModuleList{
            // Load all articles from Kontent
            new Kontent<Article>(client),
            // Set the output path for each article
            new SetDestination(KontentConfig.Get( 
                (Article item) => new NormalizedPath( $"article/{item.Slug}.html"))),
        };

        ProcessModules = new ModuleList {
            // Pull in the Razor view
            new MergeContent(new ReadFiles(patterns: "_Article.cshtml")),
            new RenderRazor()
                //.WithLayout(new NormalizedPath("_Article.cshtml"))
                // Use the strongly-typed model for the Razor view
                .WithModel(KontentConfig.As<Article>())
            // Render the Razor view into the content of the document
            
        };

        OutputModules = new ModuleList {
            new WriteFiles()
        };
    }
}