using System;

using R5T.T0142;


namespace D8S.L0014.T000
{
    [DataTypeMarker]
    public class InstanceSource_NugetPackage : InstanceSource, IEquatable<InstanceSource_NugetPackage>
    {
        public string PackageName { get; set; }
        /// <summary>
        /// Use a string since the package version might have extra tokens in it.
        /// </summary>
        public string PackageVersion { get; set; }


        public override bool Equals(object obj)
        {
            return Equals(obj as InstanceSource_NugetPackage);
        }

        public override bool Equals(InstanceSource other)
        {
            var result = Instances.TypeOperator.TypeCheckDeterminesEquality_Instance(
                this,
                other,
                (x, y) => x.Equals(y));

            return result;
        }

        public bool Equals(InstanceSource_NugetPackage other)
        {
            var output = true
                && this.PackageName == other.PackageName
                && this.PackageVersion == other.PackageVersion
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Combine(
                this.PackageName,
                this.PackageVersion);

            return output;
        }

        public override string ToString()
        {
            var output = $"{this.PackageName}/{this.PackageVersion}";
            return output;
        }
    }
}
