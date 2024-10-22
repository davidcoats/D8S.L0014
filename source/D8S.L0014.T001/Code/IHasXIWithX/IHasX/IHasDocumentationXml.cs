using System;

using R5T.T0240;


namespace D8S.L0014.T001
{
    [HasXMarker]
    public interface IHasDocumentationXml : IHasXMarker
    {
        string DocumentationXml { get; }
    }
}
