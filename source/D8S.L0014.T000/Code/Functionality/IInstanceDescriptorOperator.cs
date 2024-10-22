using System;

using R5T.T0132;

using D8S.L0014.T001;


namespace D8S.L0014.T000
{
    [FunctionalityMarker]
    public partial interface IInstanceDescriptorOperator : IFunctionalityMarker
    {
        public bool Equals_ByIdentityString_AndProjectFilePath_AndInstanceVariety(InstanceDescriptor a, InstanceDescriptor b)
        {
            var output = true
                && a.IdentityString == b.IdentityString
                && a.ProjectFilePath == b.ProjectFilePath
                && a.InstanceVariety == b.InstanceVariety
                ;

            return output;
        }

        /// <summary>
        /// Chooses <see cref="Equals_ByIdentityString_AndProjectFilePath_AndInstanceVariety"/> as the identity.
        /// </summary>
        public bool Equals_ByIdentity(InstanceDescriptor a, InstanceDescriptor b)
            => this.Equals_ByIdentityString_AndProjectFilePath_AndInstanceVariety(a, b);

        public int Get_HashCode_ByIdentityString_AndProjectFilePath_AndInstanceVariety(InstanceDescriptor a)
        {
            var output = Instances.HashCodeOperator.Combine(
                a.IdentityString,
                a.ProjectFilePath,
                a.InstanceVariety);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="Get_HashCode_ByIdentityString_AndProjectFilePath_AndInstanceVariety(InstanceDescriptor)"/> as the identity.
        /// </summary>
        public int Get_HashCode_ByIdentity(InstanceDescriptor a)
            => this.Get_HashCode_ByIdentityString_AndProjectFilePath_AndInstanceVariety(a);

        public bool Has_DocumentationXml<T>(T instanceDescriptor)
            where T : IHasDocumentationXml
        {
            var output = Instances.NullOperator.Is_NotNull(instanceDescriptor.DocumentationXml);
            return output;
        }
    }
}
