namespace Sitecore.Support.XA.Feature.Search.Repositories
{
  using Sitecore.XA.Feature.Search;

  public class RadiusFilterRepository : Sitecore.XA.Feature.Search.Repositories.RadiusFilterRepository
  {
    #region Changed code
    protected override string Title => Rendering.DataSourceItem != null ? Rendering.DataSourceItem[Templates.FacetSelector.Fields.Title] : string.Empty; 
    #endregion
  }
}