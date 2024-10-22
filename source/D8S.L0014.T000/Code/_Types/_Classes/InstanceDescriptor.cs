using System;

using R5T.T0142;

using D8S.L0014.T001;


namespace D8S.L0014.T000
{
    /// <summary>
    /// Instance descriptor data.
    /// </summary>
    [DataTypeMarker]
    public class InstanceDescriptor :
        IWithDocumentationXml
    {
        public string InstanceVariety { get; set; }
        public string IdentityString { get; set; }
        public string SignatureString { get; set; }
        public string ProjectFilePath { get; set; }
        public string DocumentationXml { get; set; }
        public DateTime LastModifiedTime { get; set; }

        public string SurveyAttributesList { get; set; }


        public override string ToString()
        {
            var output = $"{this.IdentityString}\n{this.InstanceVariety}\n{this.ProjectFilePath}";
            return output;
        }
    }
}
