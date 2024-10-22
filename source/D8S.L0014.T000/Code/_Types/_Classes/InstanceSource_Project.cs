using System;

using R5T.T0142;


namespace D8S.L0014.T000
{
    [DataTypeMarker]
    public class InstanceSource_Project : InstanceSource
    {
        public string ProjectFilePath { get; set; }


        public override bool Equals(InstanceSource other)
        {
            var result = Instances.TypeOperator.TypeCheckDeterminesEquality_Instance(
                this,
                other,
                (x, y) => x.ProjectFilePath == y.ProjectFilePath);

            return result;
        }

        public override int GetHashCode()
        {
            var output = this.ProjectFilePath.GetHashCode();
            return output;
        }

        public override string ToString()
        {
            var output = this.ProjectFilePath;
            return output;
        }
    }
}
