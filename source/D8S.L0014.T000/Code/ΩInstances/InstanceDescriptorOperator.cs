using System;


namespace D8S.L0014.T000
{
    public class InstanceDescriptorOperator : IInstanceDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceDescriptorOperator Instance { get; } = new InstanceDescriptorOperator();


        private InstanceDescriptorOperator()
        {
        }

        #endregion
    }
}
