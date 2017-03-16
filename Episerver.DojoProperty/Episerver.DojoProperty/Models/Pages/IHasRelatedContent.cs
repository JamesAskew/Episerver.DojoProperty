using EPiServer.Core;

namespace Episerver.DojoProperty.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
