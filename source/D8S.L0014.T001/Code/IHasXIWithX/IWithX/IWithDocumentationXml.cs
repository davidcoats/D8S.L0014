using System;

using R5T.T0240;


namespace D8S.L0014.T001
{
    [WithXMarker]
    public interface IWithDocumentationXml : IWithXMarker,
        IHasDocumentationXml
    {
        new string DocumentationXml { get; set; }
    }
}
